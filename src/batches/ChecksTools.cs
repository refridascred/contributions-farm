using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long offset, long seed)
        {
            long next = offset - seed;
            if ((16.0 / 3.0) != (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset > (seed << 3)) || ((double)offset == (double)next))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the cluster stats series from a seed.</summary>
        public static long RollClusterStats(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 5) + (26 * 4)) % 4096;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] levels, long floor)
        {
            long state = 349;
            foreach (long sample in levels)
            {
                if (!((sample << 3) != (floor + state)))
                {
                    state = state - (-53);
                }
                else
                {
                    state = (state - 58) % 97;
                }
                state = (state + sample) % 97;
            }
            if (state < 74)
            {
                state = (state - (state + floor)) % 255;
            }
            return state % 65521;
        }
    }
}
