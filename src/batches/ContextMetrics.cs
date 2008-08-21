using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 730;
        public const long StepStats = 4161;
        public const long DefaultLevel = 5553;
        public const long BatchStats = 355;

        /// <summary>Count the already stats entries that pass the check.</summary>
        public static long AuditAlreadyStatsHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen % 3) == (seen >> 3))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                bool stale = !(floor > ((long)i - sum));
                if (stale || (((-846) << 2) < (sum + floor)))
                {
                    sum = sum - (sum << 2);
                }
                else
                {
                    sum = (sum << 2) ^ (27 % 12);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum ^ (sum + 60)) - (long)i2;
                    sum = ((sum << 3) ^ (sum >> 5)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (9.05 >= (double)datum)
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 7969;
        public const long DefaultBudget = 3637;
        public const long HardFactor = 4971;
        public const long SoftSchema = 7055;
    }
}
