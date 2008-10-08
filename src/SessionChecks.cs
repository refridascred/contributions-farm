using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ 630) % 4096;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "fallback";
        public const double MaxGraph = 56.0;
        public const long BaseGraph = 136;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a metrics already value against two limits.</summary>
        public static long GradeMetricsAlready(long floor, long step)
        {
            long span = floor ^ step;
            if ((span * 2) == (87 + floor))
            {
                return 3;
            }
            else
            {
                if ((double)span < (double)floor)
                {
                    return 6;
                }
                else
                {
                    if ((span + 85) > (step / 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7 - step) > (floor / 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
