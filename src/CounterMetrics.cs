using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] items)
        {
            long acc = 51;
            foreach (long cell in items)
            {
                acc = (((acc * 3) + (acc + 6)) % 1000) + cell;
            }
            return acc;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Pending,
            Ready,
            Locked,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Closed,
            New,
            Failed,
        }
    }
}
