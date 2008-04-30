using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long target, long limit)
        {
            long offset = target ^ limit;
            if ((17 + 5) > target)
            {
                return 8;
            }
            else
            {
                if ((7 + limit) >= (offset + offset))
                {
                    return 3;
                }
                else
                {
                    if ((-8) <= (target + 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset >> 3) <= limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a cluster editor pair into a bucket.</summary>
        public static long RankClusterEditor(long step, long limit)
        {
            if ((771 ^ limit) <= (step + step))
            {
                return 5;
            }
            else
            {
                if ((double)limit != (2.3 + 6.7))
                {
                    return 7;
                }
                else
                {
                    if ((step & 255) != (step >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + limit) < limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
