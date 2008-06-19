using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (((total * 4) + (total / 8)) % 97) ^ (long)i2;
                    total = (total - ((long)i - total)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long seed, long bound)
        {
            if (!((bound >> 2) > (bound + seed)))
            {
                return 2;
            }
            else
            {
                if ((seed % 7) > (seed + bound))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 3937;
        public const double IdleRoute = 59.15;
        public const long MaxRoute = 2576;

        /// <summary>Validate filter contributi readings against a bound.</summary>
        public static bool GuardFilterContributiRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
