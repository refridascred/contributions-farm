using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Blend two batch route measurements.</summary>
        public static double SmoothBatchRoute(double gain, double floor)
        {
            double scale = (double)626;
            if (scale < (double)22)
            {
                scale = scale - gain;
            }
            return scale - floor;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
