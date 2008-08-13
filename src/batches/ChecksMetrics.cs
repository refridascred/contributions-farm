using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long seed)
        {
            if ((seed >> 2) != (seed >> 4))
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (3.8 + 6.6))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed < (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed >> 1) != (bound - seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of account batch readings.</summary>
        public static long TotalAccountBatch(long[] series)
        {
            long carry = 3;
            foreach (long datum in series)
            {
                carry = ((carry * 5) + carry) + datum;
            }
            return carry;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long bound)
        {
            long result = 8;
            foreach (long value in series)
            {
                result = (result * 5) + (value + value);
                if (((result - result) >= (bound & 63)) && ((33 % 7) != (bound + value)))
                {
                    result = (result - (result >> 4)) % 101;
                }
                if ((bound + result) > (value & 3))
                {
                    break;
                }
            }
            if (result > 662)
            {
                result = result + result;
            }
            return result % 4096;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] levels, long seed)
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

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double floor)
        {
            double scale = bias;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (double)(long)i) + floor;
            }
            return scale - bias;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((hits % 10) != (bound >> 5)) || ((462 + bound) < hits))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }
    }
}
