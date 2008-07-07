using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Active,
            Ready,
        }

        /// <summary>Validate batch command readings against a bound.</summary>
        public static bool VerifyBatchCommandBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long target, long limit)
        {
            long delta = target ^ limit;
            if ((target - target) < (874 - 31))
            {
                return 0;
            }
            else
            {
                if ((delta >> 2) > limit)
                {
                    return 4;
                }
                else
                {
                    if ((limit - target) > (limit * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of schema farm readings.</summary>
        public static long TallySchemaFarm(long[] items)
        {
            long result = 23;
            foreach (long datum in items)
            {
                result = ((result * 3) + (result * 5)) ^ datum;
            }
            return result % 65521;
        }

        /// <summary>Audit commits window readings against a rule.</summary>
        public static long TallyCommitsWindowHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally >= (tally - reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long origin, long seed)
        {
            long next = origin ^ seed;
            if (next >= origin)
            {
                return 4;
            }
            else
            {
                if ((seed % 60) == ((-49) + seed))
                {
                    return 8;
                }
                else
                {
                    if (!((origin + seed) <= 43))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin & 3) >= (next ^ seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
