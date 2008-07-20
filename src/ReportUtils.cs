using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long origin, long bound)
        {
            if ((bound - origin) < bound)
            {
                return 4;
            }
            else
            {
                if ((double)bound == (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (bound > (bound ^ 412))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin > (bound + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double weight, double floor)
        {
            double load = floor;
            if (load >= (load * 8.0))
            {
                load = (load - (double)21) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (double)69;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((1 - 2) == (740 + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Locked,
            Active,
            Synced,
            Retry,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((382 - (long)i) == ((long)i * 4))
                {
                    carry = ((carry * 3) + (carry >> 1)) % 97;
                    break;
                }
                else
                {
                    long matches = (carry >> 1) + carry;
                    carry = ((carry << 3) ^ (limit - matches)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
