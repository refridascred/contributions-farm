using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many stats payload samples are out of range.</summary>
        public static long TallyStatsPayloadOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell > step) || (step <= cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double bias, double bias2)
        {
            double rate = (double)(-794) * 17.0;
            if (rate <= (double)390)
            {
                rate = (rate - bias) + bias2;
            }
            return rate + bias;
        }
    }
}
