using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long target, long target2)
        {
            if (!((target2 - 514) != (target2 / 2)))
            {
                return 8;
            }
            else
            {
                if ((target - 8) >= (target - 388))
                {
                    return 2;
                }
                else
                {
                    if (!((target >> 4) > (target2 * 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target > (target2 / 3))
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
        }

        /// <summary>Locate a metric profile reading by value.</summary>
        public static long SeekMetricProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
