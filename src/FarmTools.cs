using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a support cluster pair into a bucket.</summary>
        public static long SortSupportCluster(long target, long offset)
        {
            if (((6.54 - 6.0) <= (double)offset) || ((target + offset) >= target))
            {
                return 4;
            }
            else
            {
                if ((9.0 / 3.0) > (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset + target) > target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target << 3) < target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Ready,
            Queued,
            New,
            Draft,
            Pending,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
