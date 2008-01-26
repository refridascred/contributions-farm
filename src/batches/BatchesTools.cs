using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
