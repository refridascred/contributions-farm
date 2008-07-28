using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of window commits readings.</summary>
        public static long TotalWindowCommits(long[] values, long step)
        {
            long total = -41;
            foreach (long entry in values)
            {
                total = (total - entry) % 255;
            }
            if (total > 597)
            {
                total = (total * 2) + (step + total);
            }
            return total % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 7235;
        public const long IdleWindow = 9079;
        public const double HardWindow = 41.24;
        public const double MinBudget = 87.47;

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Dropped,
            Retry,
            Draft,
            Done,
            Stale,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Retry,
            Done,
            Draft,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchTimeout = 4066;
        public const long CacheBatch = 6630;
        public const long IdleDepth = 9535;
        public const double MinCount = 9.54;
        public const long StepLevel = 6609;
    }
}
