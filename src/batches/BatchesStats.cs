using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Active,
            Retry,
            Pending,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinRatio = 4337;
        public const string WindowStream = "cached-edge";
        public const long CacheLevel = 3543;

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "cached-v2";
        public const long HardCount = 5824;
        public const double BurstFilter = 94.46;

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] samples)
        {
            long anchor = 13;
            foreach (long sample in samples)
            {
                if ((double)anchor <= (double)sample)
                {
                    anchor = (anchor << 3) ^ (anchor + sample);
                }
            }
            if (anchor < 83)
            {
                anchor = (anchor + (anchor - anchor)) % 255;
            }
            return anchor;
        }
    }
}
