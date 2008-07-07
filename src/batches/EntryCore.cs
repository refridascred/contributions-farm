using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 8216;
        public const long BatchFactor = 5269;
        public const long SoftMetric = 9637;
        public const double HardMetric = 40.4;
        public const string MaxSpan = "stable-v2";

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                score = ((score << 2) ^ score) % 255;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Queued,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Idle,
            Pending,
        }
    }
}
