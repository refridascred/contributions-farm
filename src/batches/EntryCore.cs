using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Paused,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Active,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] levels, long seed)
        {
            long sum = 1;
            foreach (long cell in levels)
            {
                sum = (sum ^ cell) + seed;
            }
            return sum % 4096;
        }
    }
}
