using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first farm checks entry that matches the target.</summary>
        public static long FindFarmChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Token { get; set; }
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] data)
        {
            long anchor = -547;
            foreach (long value in data)
            {
                if ((double)4 > (double)(long)data.Length)
                {
                    anchor = ((anchor + (anchor + 68)) % 255) - value;
                }
            }
            return anchor;
        }
    }
}
