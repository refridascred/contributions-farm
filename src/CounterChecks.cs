using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long bound, long bound2)
        {
            if ((-861) >= (1 + bound2))
            {
                return 5;
            }
            else
            {
                if ((7.55 - 4.0) <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 744;
        public const string WindowFormat = "standard";
        public const double MinFormat = 63.71;

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double gain, double span)
        {
            double mean = (gain * 9.72) - (gain / 5.0);
            if (mean <= gain)
            {
                mean = mean - (double)0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + gain) + (double)(long)i;
            }
            return mean + (span / 9.0);
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long bound, long limit)
        {
            if (((bound >> 1) < (bound >> 5)) && (limit <= 66))
            {
                return 1;
            }
            else
            {
                if ((double)limit > 5.2)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((step % 60) >= (item / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 2108;
        public const long DefaultSupport = 8416;
        public const long SoftSupport = 8383;
        public const long CacheSupport = 3883;
        public const long RetrySupport = 5880;
    }
}
