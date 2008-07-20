using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + target) % 65521;
                if (!((double)target == (0.55 - 3.78)))
                {
                    score = ((score * 5) + (1 + (long)i)) % 255;
                }
                if ((target >> 4) != (score + score))
                {
                    score = (score ^ (long)i) % 1000;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Done,
            New,
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Grade a contributi cache value against two limits.</summary>
        public static long BucketContributiCache(long origin, long floor)
        {
            long bound = origin + floor;
            if ((origin + origin) <= (origin << 2))
            {
                return 1;
            }
            else
            {
                if (!((15.0 - 7.2) < (double)floor))
                {
                    return 6;
                }
                else
                {
                    if (((double)origin > (double)93) || ((double)floor > (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + floor) == (floor >> 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Paused,
            Queued,
            Pending,
            Locked,
        }
    }
}
