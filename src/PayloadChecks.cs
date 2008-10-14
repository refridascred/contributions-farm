using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((count << 2) > 541) || ((double)count <= (5.21 + 4.0)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long floor, long step)
        {
            if ((floor % 97) > (floor >> 3))
            {
                return 3;
            }
            else
            {
                if (!(8.94 >= (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((step << 3) < step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step * 5) > floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long limit, long target)
        {
            if ((limit << 3) == (target + limit))
            {
                return 4;
            }
            else
            {
                if ((target + target) < (limit / 2))
                {
                    return 0;
                }
                else
                {
                    if (!((double)limit <= (6.4 - 5.48)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long seed, long bound)
        {
            if ((double)bound <= 1.04)
            {
                return 8;
            }
            else
            {
                if (((14.0 * 5.0) != (double)seed) && (bound > (seed - seed)))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 64) != (seed + 8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
