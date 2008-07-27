using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double gain, double floor)
        {
            double scale = gain;
            if (scale > 6.5)
            {
                scale = scale + (scale + floor);
            }
            else
            {
                scale = scale + (gain - 8.68);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (floor + floor)) + (double)(long)i;
            }
            return scale + 1.35;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 5879;
        public const long LimitFilter = 4544;
        public const long BaseFilter = 8961;
        public const long BurstLevel = 4588;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen % 16) > ((long)data.Length + seen))
                {
                    seen = ((seen + 1) - cell) - origin;
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally ^ value) <= (long)series.Length)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
