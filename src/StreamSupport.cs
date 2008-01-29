using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Score { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a batches context sample.</summary>
        public static long LocateBatchesContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
