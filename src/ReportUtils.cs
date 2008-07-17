using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next counter order value from a seed.</summary>
        public static long RollCounterOrder(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((double)seed >= 5.5)
                {
                    anchor = (anchor << 3) ^ (seed << 2);
                }
                else
                {
                    anchor = anchor + (seed + seed);
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values)
        {
            long mark = 296;
            foreach (long cell in values)
            {
                mark = (mark * 2) + cell;
            }
            if (mark < 39)
            {
                mark = (mark ^ (90 % 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultScore = 9630;
        public const long StepFactor = 9241;
        public const string StepCount = "strict";

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "standard-edge";
        public const long HardRoute = 4970;
        public const long MaxInterval = 2549;
        public const long BurstRoute = 4074;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchWidth = 9960;
        public const long IdleFactor = 521;
        public const string DefaultContributi = "open-edge";
        public const double CacheContributi = 88.85;
        public const string DefaultInterval = "staging-v2";
    }
}
