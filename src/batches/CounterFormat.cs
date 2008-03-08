using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] items, long target)
        {
            long sum = -2;
            foreach (long entry in items)
            {
                if ((5.9 * 7.0) == (double)sum)
                {
                    sum = (((sum * 3) + (target + 0)) % 4096) + entry;
                }
            }
            if (sum < 56)
            {
                sum = ((sum * 4) + (sum + 927)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long limit, long bound)
        {
            if ((limit * 5) == (limit >> 5))
            {
                return 7;
            }
            else
            {
                if ((bound ^ bound) <= ((-568) + bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound >= (limit ^ bound)) && ((bound + 4) <= (bound & 15)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound > 7.9)
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
        }
    }
}
