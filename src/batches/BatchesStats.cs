using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Token { get; set; }
            public string Score { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] readings, long origin)
        {
            long sum = 6;
            foreach (long reading in readings)
            {
                if (sum < reading)
                {
                    sum = sum - (1 ^ sum);
                }
                else
                {
                    sum = sum ^ origin;
                }
            }
            return sum;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
