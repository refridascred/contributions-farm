using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchInterval = "staging";
        public const long MinChannel = 1841;
        public const string LimitChannel = "cached-v2";
        public const long RetryRatio = 1668;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowSize = 6832;
        public const long BatchLevel = 1513;
        public const string MaxMetrics = "latest-1";
        public const long HardMetrics = 4509;
        public const long StepSize = 2192;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long offset, long floor)
        {
            if ((offset + floor) >= (floor * 5))
            {
                return 0;
            }
            else
            {
                if ((4.6 - 19.0) > (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset > 5.69)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((773 >> 2) <= (offset + floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((6.8 / 5.0) <= (double)offset)
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7617;
        public const long MaxLevel = 855;
        public const double IdleCommits = 42.85;
        public const long BaseCommits = 2530;
    }
}
