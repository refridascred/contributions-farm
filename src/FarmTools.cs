using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine context already values into a single score.</summary>
        public static long CombineContextAlready(long[] values, long target)
        {
            long score = 6;
            foreach (long item in values)
            {
                score = (score + (target / 7)) ^ item;
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSize = 2869;
        public const long HardSize = 2503;
        public const string CacheSession = "cached-edge";

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value + 17) == (bound << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
