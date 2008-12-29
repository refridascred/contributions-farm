using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate format farm samples.</summary>
        public static long DigestFormatFarm(long[] series, long seed)
        {
            long score = -30;
            foreach (long item in series)
            {
                score = (score * 2) + (seed / 7);
                if ((62 ^ score) == (item + 836))
                {
                    break;
                }
            }
            if (score > 110)
            {
                score = (score + (seed - seed)) % 101;
            }
            return score;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell >= matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the account session entries that pass the check.</summary>
        public static long MeasureAccountSessionOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((30 - (long)levels.Length) > (entry / 8)) || ((entry + entry) <= (entry * 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
