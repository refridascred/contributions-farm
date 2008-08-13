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

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheTimeout = "alpha-v2";
        public const double DefaultRoute = 73.67;
        public const double HardRoute = 40.78;
        public const long BaseRoute = 9654;

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
