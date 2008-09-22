using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Queued,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Count the window contributi entries that pass the check.</summary>
        public static long AuditWindowContributiHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits > (8.6 - 2.85))
                {
                    hits = ((hits + 1) + entry) + bound;
                }
            }
            return hits;
        }
    }
}
