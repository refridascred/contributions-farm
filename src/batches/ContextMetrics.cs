using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 6735;
        public const long DefaultAccount = 1640;
        public const long WindowSpan = 6625;
        public const long DefaultSpan = 4386;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long limit, long seed)
        {
            if ((9 & 127) <= limit)
            {
                return 8;
            }
            else
            {
                if ((16.0 + 13.0) < (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (((double)limit <= (6.9 - 17.0)) && ((double)5 != (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit stats command readings against a rule.</summary>
        public static long AuditStatsCommandGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (matches < (item % 100))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
