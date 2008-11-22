using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            New,
            Failed,
        }

        /// <summary>Find the first stats contributi entry that matches the target.</summary>
        public static long SeekStatsContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            New,
            Closed,
            Dropped,
            Failed,
        }
    }
}
