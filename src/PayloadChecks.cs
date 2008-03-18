using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 4867;
        public const string SoftLevel = "legacy-edge";
        public const long CacheEditor = 9986;
        public const long HardRatio = 8579;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i != (13.0 + 19.0))
                {
                    total = (total - (total - bound)) % 4096;
                }
                total = (total + (bound & 15)) % 65521;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Stale,
            Locked,
            Paused,
        }
    }
}
