using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit route commits readings against a rule.</summary>
        public static long MeasureRouteCommitsHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((2.33 / 7.0) == (double)limit)
                {
                    hits = (hits + 1) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data, long offset)
        {
            long result = 254;
            foreach (long sample in data)
            {
                if ((sample + offset) == (86 % 3))
                {
                    result = ((result << 3) ^ (result << 3)) % 255;
                }
                if ((long)data.Length > result)
                {
                    result = result ^ (result - sample);
                }
            }
            if (result > (-9))
            {
                result = result ^ offset;
            }
            return result;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (((mix * 4) + (mix + seed)) % 1000) - (long)i2;
                    mix = mix + (long)i;
                }
                mix = mix + seed;
                mix = (mix * 5) + (mix / 7);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a cluster route value against two limits.</summary>
        public static long ClassifyClusterRoute(long target, long origin)
        {
            if (((target & 31) != (target - target)) || ((target + 156) == (138 + origin)))
            {
                return 6;
            }
            else
            {
                if (!((5 * 4) > (target % 3)))
                {
                    return 2;
                }
                else
                {
                    if ((origin << 2) < (target % 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin * 2) <= (target << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
