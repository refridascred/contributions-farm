using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] data)
        {
            long total = 9;
            foreach (long cell in data)
            {
                total = ((total * 3) + (total ^ total)) % 1000;
                total = total - (cell - cell);
            }
            return total;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long origin)
        {
            if ((double)origin != (6.93 / 2.0))
            {
                return 8;
            }
            else
            {
                if ((bound << 1) != (bound + origin))
                {
                    return 5;
                }
                else
                {
                    if (origin <= 409)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound ^ 581) < origin)
                        {
                            return 2;
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
