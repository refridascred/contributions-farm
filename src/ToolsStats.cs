using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseFactor = 7.54;
        public const double CacheBudget = 65.64;
        public const long BurstTimeout = 7720;

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] items, long limit)
        {
            long mark = 30;
            foreach (long entry in items)
            {
                mark = ((((mark << 3) ^ 3) % 101) + entry) + limit;
                mark = (mark + ((-71) + mark)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultFactor = 92.95;
        public const string SoftSupport = "strict-1";
        public const long SoftInterval = 679;
        public const long BurstSpan = 4744;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long origin)
        {
            if (((-848) / 9) <= (target + origin))
            {
                return 5;
            }
            else
            {
                if ((origin / 5) > (target >> 2))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double bias, double span)
        {
            double rate = 11.0;
            if (rate > (double)358)
            {
                rate = (rate - (span * 3.53)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate - 2.7;
        }
    }
}
