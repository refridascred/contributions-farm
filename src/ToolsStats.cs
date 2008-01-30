using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long target)
        {
            if (0.9 >= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((target % 12) >= (target & 7))
                {
                    return 8;
                }
                else
                {
                    if (!((target + limit) >= 832))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long floor, long target)
        {
            long next = floor - target;
            if ((double)next == (double)floor)
            {
                return 0;
            }
            else
            {
                if ((floor % 3) <= next)
                {
                    return 8;
                }
                else
                {
                    if ((double)target >= (20.0 - 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target >> 5) > 4)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitSize = 4718;
        public const double CacheReport = 40.17;
        public const long LimitDepth = 9713;
        public const long MinReport = 9980;

        /// <summary>Audit support token readings against a rule.</summary>
        public static long CountSupportTokenHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((748 >> 2) <= matches)
                {
                    matches = ((matches + 1) ^ item) - origin;
                }
            }
            return matches;
        }
    }
}
