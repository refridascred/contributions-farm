using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSpan = 2841;
        public const long DefaultInterval = 4571;
        public const string BurstWindow = "open-v2";
        public const long StepBudget = 7760;
        public const long CacheSize = 2096;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 60.42;
        public const double LimitScore = 91.09;
        public const double MaxRatio = 73.22;
        public const long MaxInterval = 5275;
        public const long MaxScore = 1232;

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long floor, long bound)
        {
            if ((2.0 - 3.0) >= (double)floor)
            {
                return 5;
            }
            else
            {
                if ((bound << 3) == (floor + floor))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor == (double)902)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many buffer order samples are out of range.</summary>
        public static long CountBufferOrderGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (11.0 >= (double)count)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
