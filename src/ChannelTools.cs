using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
