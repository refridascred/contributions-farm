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

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 7424;
        public const long RetryFilter = 1979;
        public const long BurstFactor = 8356;
        public const long IdleFilter = 9068;
        public const double WindowRatio = 88.75;
    }
}
