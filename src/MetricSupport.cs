using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long bound, long target)
        {
            long slot = bound - target;
            if ((slot >> 5) <= (bound ^ target))
            {
                return 5;
            }
            else
            {
                if (target <= (bound * 5))
                {
                    return 4;
                }
                else
                {
                    if ((target > bound) && ((slot << 2) >= (bound - target)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long target2)
        {
            if (!((target - target) < (75 + 8)))
            {
                return 3;
            }
            else
            {
                if (!((double)target <= (double)51))
                {
                    return 2;
                }
                else
                {
                    if ((target >> 3) < (target << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)921 > (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
