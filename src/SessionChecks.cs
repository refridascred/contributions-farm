using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long bound2)
        {
            long edge = bound + bound2;
            if (((bound - 4) < (edge - bound)) && ((double)bound2 == (double)59))
            {
                return 6;
            }
            else
            {
                if ((double)bound >= (1.8 * 7.6))
                {
                    return 8;
                }
                else
                {
                    if ((bound + bound2) < 60)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound < (6.2 - 5.61))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double gain, double bias)
        {
            double load = gain;
            return (load - (1.5 / 4.0)) + bias;
        }
    }
}
