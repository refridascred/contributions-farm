using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long target, long limit)
        {
            long lane = target - limit;
            if ((54 >= (limit + limit)) && ((lane * 3) <= (lane - lane)))
            {
                return 7;
            }
            else
            {
                if (!((limit + 4) <= (target & 127)))
                {
                    return 0;
                }
                else
                {
                    if ((target ^ limit) > (target * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((target / 5) != (lane / 4)) || ((113 / 4) <= (target + lane)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cluster batch readings against a bound.</summary>
        public static bool VerifyClusterBatchLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Locked,
            Draft,
            New,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a farm batch pair into a bucket.</summary>
        public static long RankFarmBatch(long origin, long offset)
        {
            if ((992 + offset) < 0)
            {
                return 1;
            }
            else
            {
                if ((origin >> 2) > (offset - offset))
                {
                    return 2;
                }
                else
                {
                    if ((19.0 + 19.0) != (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >> 3) != (origin + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
