using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long bound, long seed)
        {
            if (!((double)bound < (0.74 * 7.2)))
            {
                return 5;
            }
            else
            {
                if ((double)seed <= (8.0 - 8.77))
                {
                    return 7;
                }
                else
                {
                    if (!((seed & 3) >= (seed / 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next report filter value from a seed.</summary>
        public static long StepReportFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 255;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
