using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7851;
        public const double CacheWidth = 34.21;
        public const long RetryWidth = 211;
        public const long MaxCommits = 3691;
        public const long BurstCommits = 7574;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long limit, long limit2)
        {
            if (limit2 > (limit2 & 3))
            {
                return 2;
            }
            else
            {
                if ((137 << 3) <= limit2)
                {
                    return 7;
                }
                else
                {
                    if ((limit2 <= (limit + limit2)) || ((limit * 4) > ((-3) + limit2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit & 31) > (limit2 ^ limit)) || ((limit2 + limit2) > (limit2 * 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Stamp { get; set; }
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
