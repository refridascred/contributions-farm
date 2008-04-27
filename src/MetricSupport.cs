using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long target, long origin)
        {
            if ((4.86 + 12.0) == (double)target)
            {
                return 1;
            }
            else
            {
                if (((double)origin >= (19.0 + 9.0)) && ((origin + target) > 6))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long seed, long limit)
        {
            long lane = seed ^ limit;
            if ((lane >> 5) == (limit + lane))
            {
                return 5;
            }
            else
            {
                if ((lane - 835) != (lane >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((6.43 >= (double)limit) && ((87 - lane) <= (lane << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)lane > 2.0)
                        {
                            return 4;
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
}
