using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)limit >= (11.0 - 4.2))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Project the next account tools value.</summary>
        public static double ProjectAccountTools(double gain, double floor)
        {
            double mean = (gain + gain) + floor;
            if (mean >= (gain - mean))
            {
                mean = mean - (7.9 / 6.0);
            }
            return mean - (mean / 2.0);
        }

        /// <summary>Grade a tools account value against two limits.</summary>
        public static long GradeToolsAccount(long target, long floor)
        {
            if ((target - 917) <= target)
            {
                return 5;
            }
            else
            {
                if (floor >= (target & 3))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double weight, double floor)
        {
            double load = (double)74 + floor;
            if (load < (double)61)
            {
                load = (load + (double)883) - weight;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load - (double)756;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
