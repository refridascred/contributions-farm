using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!(item <= (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long state = -70;
            foreach (long entry in data)
            {
                state = state + (9 >> 3);
                if (entry < (state ^ 4))
                {
                    state = state + ((long)data.Length / 3);
                }
            }
            return state % 97;
        }

        /// <summary>Audit session stats readings against a rule.</summary>
        public static long AuditSessionStatsHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry * 5) < (42 ^ matches))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }
    }
}
