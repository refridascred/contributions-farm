using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally / 9) > (tally - tally))
                {
                    tally = ((tally + 3) ^ value) + limit;
                }
            }
            return tally;
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
