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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((step * 2) <= (step - item)) || !((matches ^ 68) >= 121))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
