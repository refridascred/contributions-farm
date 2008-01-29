using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a batch editor value against two limits.</summary>
        public static long BucketBatchEditor(long limit, long limit2)
        {
            long prev = limit + limit2;
            if (7.51 >= (double)limit)
            {
                return 5;
            }
            else
            {
                if (((limit2 & 31) >= (789 % 5)) && ((double)limit2 >= 6.16))
                {
                    return 6;
                }
                else
                {
                    if ((limit + limit2) == (prev + limit2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] levels)
        {
            long acc = -9;
            foreach (long sample in levels)
            {
                long seen = (acc + acc) - ((-38) + 50);
                if (!((((long)levels.Length << 1) <= (acc & 127)) || ((61 * 5) >= (seen + sample))))
                {
                    acc = acc - seen;
                }
                acc = (acc ^ (sample % 5)) % 255;
            }
            if (acc < (-101))
            {
                acc = ((acc << 2) ^ (acc << 1)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 > (bias * 2.33))
            {
                bias2 = bias2 - (6.0 * 2.0);
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + bias2;
        }
    }
}
