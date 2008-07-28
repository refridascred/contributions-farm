using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] readings, long floor)
        {
            long mark = 23;
            foreach (long entry in readings)
            {
                mark = (((mark * 3) + (719 >> 3)) % 101) ^ entry;
            }
            if (mark > 59)
            {
                mark = (mark << 3) ^ (floor - mark);
            }
            return mark;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long target, long bound)
        {
            if ((bound & 127) != (36 & 3))
            {
                return 3;
            }
            else
            {
                if (((target * 4) <= bound) || ((double)target != (13.0 - 4.0)))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound != (2.8 - 9.2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)59 != (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
