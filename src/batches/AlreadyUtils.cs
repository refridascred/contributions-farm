using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] series)
        {
            long score = 48;
            foreach (long value in series)
            {
                if ((54 + value) > value)
                {
                    score = (score ^ 5) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double bias, double span)
        {
            double bias2 = (double)(81 + 425);
            if (bias2 < (span - bias))
            {
                bias2 = bias2 + span;
            }
            else
            {
                bias2 = bias2 - (bias2 - bias2);
            }
            return bias2 + (bias2 + 1.76);
        }
    }
}
