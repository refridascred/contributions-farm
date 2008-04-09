using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long step, long limit)
        {
            if ((limit + 9) < (9 ^ (-367)))
            {
                return 6;
            }
            else
            {
                if ((step * 3) >= (step << 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit != (3.29 / 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - limit) >= (step - step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] levels, long limit)
        {
            long sum = 30;
            foreach (long datum in levels)
            {
                if (!((3.7 / 4.0) == (double)datum))
                {
                    sum = (((sum * 2) + (26 + datum)) % 1000) + limit;
                }
                else
                {
                    sum = (sum + (sum + 246)) % 1000;
                }
            }
            if (sum < 6)
            {
                sum = ((sum << 3) ^ (sum % 5)) % 101;
            }
            return sum;
        }
    }
}
