using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a account cluster reading.</summary>
        public static double ScaleAccountCluster(double ratio, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - floor) - (double)(long)i) + ratio;
            }
            return drift - 3.4;
        }

        /// <summary>Count the filter profile entries that pass the check.</summary>
        public static long CountFilterProfileMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((213 - 3) > item)
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] items)
        {
            long result = -4;
            foreach (long value in items)
            {
                if ((value / 6) >= (value ^ value))
                {
                    result = (result * 4) + (value * 5);
                    break;
                }
                else
                {
                    result = ((result * 3) + 91) % 4096;
                }
                if ((10 * 4) >= (4 - result))
                {
                    result = result ^ (129 + 6);
                }
            }
            return result;
        }
    }
}
