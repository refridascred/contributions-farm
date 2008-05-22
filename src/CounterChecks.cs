using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "alpha";
        public const double BaseToken = 78.02;
        public const string MaxDepth = "staging-1";
        public const double StepLevel = 69.27;
        public const double MaxRatio = 88.59;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((offset & 1) >= (offset + offset))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 469;
        public const double WindowDepth = 26.33;
        public const long LimitOrder = 1573;
        public const double CacheScore = 15.76;
        public const long LimitSpan = 4097;

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] samples, long limit)
        {
            long anchor = -4;
            foreach (long item in samples)
            {
                anchor = (anchor << 2) ^ (limit & 15);
                if ((((-45) % 100) >= ((-17) + anchor)) && ((item & 255) > limit))
                {
                    anchor = (anchor + (item - anchor)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (-3)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double ratio, double bias)
        {
            double drift = 3.86;
            if (drift < (double)0)
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (bias - ratio)) + (double)(long)i;
            }
            return drift - (double)520;
        }
    }
}
