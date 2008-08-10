using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a farm graph value against two limits.</summary>
        public static long BucketFarmGraph(long limit, long offset)
        {
            if (((offset + offset) >= (limit << 1)) && ((offset << 2) <= ((-355) - offset)))
            {
                return 4;
            }
            else
            {
                if ((limit + limit) > 68)
                {
                    return 0;
                }
                else
                {
                    if ((double)offset < (9.64 * 6.21))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((12.0 / 9.0) != (double)limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(((value & 7) != (tally - origin)) && ((double)tally < (double)origin)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 7424;
        public const long RetryFilter = 1979;
        public const long BurstFactor = 8356;
        public const long IdleFilter = 9068;
        public const double WindowRatio = 88.75;
    }
}
