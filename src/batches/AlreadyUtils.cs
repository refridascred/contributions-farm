using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] readings, long origin)
        {
            long state = 4;
            foreach (long value in readings)
            {
                if (!((origin + state) < (origin & 63)))
                {
                    state = (((state * 2) + (state / 6)) % 97) ^ value;
                }
            }
            return state;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long step, long target)
        {
            if ((double)target <= (1.0 + 17.0))
            {
                return 0;
            }
            else
            {
                if ((step + step) < (1 >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((12 - (-2)) <= (target / 4))
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

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((origin % 16) != (origin ^ 1)) && (state < (long)i))
                {
                    state = (state + state) % 1000;
                    state = (state ^ origin) % 97;
                }
                else
                {
                    state = (state - (91 / 3)) % 4096;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!(result <= (origin % 7)))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a stats route value against two limits.</summary>
        public static long BucketStatsRoute(long offset, long seed)
        {
            if (((seed + seed) <= (seed + 49)) && ((offset * 4) > offset))
            {
                return 8;
            }
            else
            {
                if ((offset + seed) <= 21)
                {
                    return 1;
                }
                else
                {
                    if (((7.19 / 3.0) == (double)offset) || ((offset ^ seed) < seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed < (seed & 7))
                        {
                            return 5;
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
