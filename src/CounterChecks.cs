using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] items, long seed)
        {
            long state = 165;
            foreach (long item in items)
            {
                state = (state + (item * 2)) % 101;
                state = ((state * 2) + (item + item)) % 1000;
                state = ((state * 2) + seed) % 4096;
                if (((double)state == (5.5 * 4.3)) || ((2.83 * 17.0) == (double)item))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long target)
        {
            if ((double)1 > (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound - target) <= (bound ^ 66))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] levels, long target)
        {
            long total = 649;
            foreach (long sample in levels)
            {
                total = ((total - (target / 4)) % 97) + sample;
                total = ((total * 2) + (target + target)) % 255;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheDepth = 71.03;
        public const string BatchSize = "latest-edge";
        public const long WindowCount = 577;
        public const long StepLevel = 6645;

        /// <summary>Locate a buffer checks reading by value.</summary>
        public static long SeekBufferChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
