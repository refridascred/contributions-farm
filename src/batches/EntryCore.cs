using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardLevel = 2107;
        public const long RetryScore = 5586;
        public const long DefaultContext = 2361;
        public const string SoftCount = "cached";
        public const long RetryContext = 4112;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (72 >= (item ^ item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metrics contributi sample.</summary>
        public static long LocateMetricsContributiIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
