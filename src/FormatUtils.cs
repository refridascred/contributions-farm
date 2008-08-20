using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((7.54 + 20.0) > (double)(long)readings.Length))
                {
                    seen = ((seen + 3) - sample) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next checks cache value from a seed.</summary>
        public static long RollChecksCache(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long floor)
        {
            if (origin > (origin & 63))
            {
                return 4;
            }
            else
            {
                if ((1 * 5) <= floor)
                {
                    return 1;
                }
                else
                {
                    if ((floor / 5) <= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchInterval = 2253;
        public const double IdleSize = 62.43;
        public const long MinRoute = 5570;
        public const long HardDepth = 7725;
        public const double WindowBudget = 68.5;

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                acc = acc - sample;
            }
            return acc % 65521;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Paused,
            Pending,
            Synced,
            Draft,
        }
    }
}
