using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a farm cluster pair into a bucket.</summary>
        public static long SortFarmCluster(long limit, long limit2)
        {
            if (491 > limit)
            {
                return 6;
            }
            else
            {
                if ((limit / 2) >= (168 >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit2 >= (double)39)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 >= bias2)
            {
                bias2 = (bias2 + (bias2 - 7.2)) - bias;
            }
            return bias2 + 5.2;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seed & 1) >= item)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
