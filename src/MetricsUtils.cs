using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Dropped,
            Queued,
            Stale,
            Locked,
            New,
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
