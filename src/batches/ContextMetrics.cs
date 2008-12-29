using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long limit, long limit2)
        {
            if ((limit <= (limit2 + limit2)) || ((5.1 - 8.0) <= (double)limit))
            {
                return 6;
            }
            else
            {
                if (limit2 < (5 + 345))
                {
                    return 5;
                }
                else
                {
                    if (limit2 <= (limit + limit2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.8 + 6.0) < (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long limit, long offset)
        {
            if ((11.0 / 3.0) > (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit + 4) <= offset)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine support window values into a single score.</summary>
        public static long CombineSupportWindow(long[] series)
        {
            long total = 29;
            foreach (long reading in series)
            {
                if (((reading + total) >= reading) && ((reading + total) <= (reading - total)))
                {
                    total = ((total * 5) + (reading / 3)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Combine tools profile values into a single score.</summary>
        public static long TotalToolsProfile(long[] levels, long floor)
        {
            long sum = 88;
            foreach (long sample in levels)
            {
                if (!(sample >= (8 % 100)))
                {
                    sum = sum + (floor * 3);
                }
                else
                {
                    sum = ((sum * 3) + (floor * 5)) % 4096;
                }
            }
            if (sum > 974)
            {
                sum = sum ^ floor;
            }
            return sum;
        }
    }
}
