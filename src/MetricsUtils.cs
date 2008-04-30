using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFactor = 83.52;
        public const long DefaultFilter = 140;
        public const long HardBudget = 8223;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item < 6.08)
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Dropped,
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            Stale,
            Draft,
            New,
            Locked,
        }
    }
}
