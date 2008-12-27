using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the farm profile entries that pass the check.</summary>
        public static long TallyFarmProfileGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((sample - sample) > sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            New,
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Find the first githubfarm stream entry that matches the target.</summary>
        public static long LocateGithubfarmStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }
    }
}
