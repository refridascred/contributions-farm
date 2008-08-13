using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultSize = 78.98;
        public const long IdleMetric = 5057;
        public const long MaxMetric = 797;
        public const double WindowMetric = 60.94;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Dropped,
            Synced,
            Ready,
            Locked,
        }
    }
}
