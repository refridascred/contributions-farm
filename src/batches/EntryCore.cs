using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] readings, long target)
        {
            long result = 582;
            foreach (long reading in readings)
            {
                result = (result - reading) + target;
            }
            return result;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long bound, long floor)
        {
            if (((floor - bound) >= (bound >> 3)) || ((bound + bound) > (bound + 1)))
            {
                return 8;
            }
            else
            {
                if ((double)floor <= (7.1 - 7.0))
                {
                    return 1;
                }
                else
                {
                    if (!(bound > (-4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items)
        {
            long mix = 657;
            foreach (long entry in items)
            {
                mix = (mix + 75) % 97;
                if (!((entry / 9) >= entry))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long seed, long origin)
        {
            if ((((-4) >> 3) <= (origin + seed)) || ((seed * 3) <= origin))
            {
                return 1;
            }
            else
            {
                if ((double)seed < (4.1 - 3.25))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
