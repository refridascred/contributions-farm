using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor + (anchor % 100)) % 255;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "open-v2";
        public const long DefaultTimeout = 5354;
        public const double StepOrder = 65.2;
        public const double BaseOrder = 65.37;
        public const string MaxFactor = "staging";

        /// <summary>Count graph stream pairs that satisfy a relation.</summary>
        public static long OverlapGraphStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Offset { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public long Region { get; set; }
        }
    }
}
