using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Active,
            Dropped,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long limit, long target)
        {
            long offset = limit + target;
            if (target < (offset + target))
            {
                return 2;
            }
            else
            {
                if ((target % 12) == (offset << 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit != (double)8)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
