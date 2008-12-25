using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepLevel = 6253;
        public const long MinScore = 6183;
        public const string BurstDepth = "latest-v2";
        public const long BatchCount = 8419;
        public const long CacheInterval = 7791;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Idle,
            Paused,
            Done,
            New,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] values, long bound)
        {
            long score = 18;
            foreach (long datum in values)
            {
                if ((bound * 5) < datum)
                {
                    score = (score - (datum - 623)) % 4096;
                }
            }
            return score;
        }
    }
}
