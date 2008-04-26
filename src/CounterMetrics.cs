using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((-251) > origin) && ((double)tally == (20.0 - 9.6)))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of commits filter readings.</summary>
        public static long PairCommitsFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Idle,
            Done,
            Stale,
            Active,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings)
        {
            long total = 38;
            foreach (long entry in readings)
            {
                if ((323 + 5) == (total - entry))
                {
                    total = (total - (entry % 12)) % 101;
                }
                else
                {
                    total = ((total * 5) + (entry >> 4)) % 255;
                }
            }
            if (total > 92)
            {
                total = (total ^ (total % 3)) % 101;
            }
            return total % 4096;
        }
    }
}
