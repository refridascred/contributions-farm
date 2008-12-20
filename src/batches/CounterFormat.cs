using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long seed, long target)
        {
            if ((seed >> 5) <= ((-9) << 2))
            {
                return 0;
            }
            else
            {
                if (((double)target <= 1.7) && ((seed ^ seed) < seed))
                {
                    return 8;
                }
                else
                {
                    if (((16.0 / 7.0) >= (double)seed) || ((seed - target) > seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target ^ target) > (target + target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long seed, long target)
        {
            long next = seed ^ target;
            if (0 >= (next % 60))
            {
                return 0;
            }
            else
            {
                if ((next % 8) > (target * 2))
                {
                    return 4;
                }
                else
                {
                    if (target < (next + next))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)seed > (double)target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account report entries that pass the check.</summary>
        public static long MeasureAccountReportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (702 >= (cell << 1))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
