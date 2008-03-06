using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a profile route value against two limits.</summary>
        public static long SortProfileRoute(long origin, long floor)
        {
            if (((floor & 127) != (floor ^ origin)) || ((1 & 15) >= (origin & 255)))
            {
                return 3;
            }
            else
            {
                if ((floor - 47) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin < (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next record batches value.</summary>
        public static double AdjustRecordBatches(double weight, double offset)
        {
            double mean = 0.17;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + offset) + (double)(long)i) - weight;
            }
            return mean - mean;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches == (6.9 - 3.9))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
