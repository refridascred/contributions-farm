using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double rate = gain;
            if (rate > (double)66)
            {
                rate = (rate + (5.0 / 4.0)) + offset;
            }
            else
            {
                rate = rate + (13.0 + gain);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxSpan = 2226;
        public const double HardScore = 73.45;
        public const long IdleBatch = 7506;
        public const long MinBatch = 4971;
        public const double LimitBatch = 40.58;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (origin < (entry * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
