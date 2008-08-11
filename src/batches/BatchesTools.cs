using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = total + total;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long bound, long origin)
        {
            if ((824 - bound) <= origin)
            {
                return 7;
            }
            else
            {
                if ((696 + 4) < (bound >> 4))
                {
                    return 6;
                }
                else
                {
                    if ((origin - bound) == (bound - (-2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound >= (double)origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
