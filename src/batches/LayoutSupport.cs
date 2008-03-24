using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the stats cache entries that pass the check.</summary>
        public static long MeasureStatsCacheOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((3 * 5) >= tally)
                {
                    tally = ((tally + 2) ^ datum) + offset;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] values, long seed)
        {
            long sum = 41;
            foreach (long cell in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum + (cell + (long)i)) % 255) - seed;
                }
                if (!((cell ^ sum) > cell))
                {
                    sum = (sum << 3) ^ (cell << 2);
                }
                else
                {
                    sum = (sum - (11 & 31)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double rate, double floor)
        {
            double gain = (double)(5 << 2);
            if (gain < 6.6)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + floor;
            }
            return gain + (floor - rate);
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Failed,
            Stale,
            Draft,
            Paused,
            Active,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
