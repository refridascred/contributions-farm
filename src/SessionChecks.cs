using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long seed, long seed2)
        {
            if (!((seed2 >> 2) <= (seed2 / 4)))
            {
                return 2;
            }
            else
            {
                if ((8.38 - 6.7) >= (double)seed)
                {
                    return 7;
                }
                else
                {
                    if (seed < (seed2 << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed > (seed >> 2)) || ((seed2 / 6) == (seed & 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long limit, long limit2)
        {
            if (!((limit2 ^ limit2) > (limit2 - limit2)))
            {
                return 7;
            }
            else
            {
                if (limit > (limit % 10))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit2 >= (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((limit + limit) > (limit2 % 3)))
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

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Closed,
            Active,
            Queued,
            New,
        }
    }
}
