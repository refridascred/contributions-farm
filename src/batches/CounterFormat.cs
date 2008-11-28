using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up order filter samples.</summary>
        public static long CompareOrderFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)(long)levels.Length > (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((seed + 581) >= (tally / 2))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }
    }
}
