using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (3.44 <= (double)tally)
                {
                    tally = ((tally + 3) + reading) + limit;
                }
            }
            return tally;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double bias, double bias2)
        {
            double bias3 = (double)(6 << 2);
            if (bias3 < bias)
            {
                bias3 = bias3 + (bias2 / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias3 = bias3 - (double)(long)i;
            }
            return bias3 - (double)4;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first token entry entry that matches the target.</summary>
        public static long LookupTokenEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryScore = 9842;
        public const long StepQueue = 1401;
        public const long LimitQueue = 2296;
    }
}
