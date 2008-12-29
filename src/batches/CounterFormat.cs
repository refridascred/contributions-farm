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

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            New,
            Stale,
            Synced,
            Dropped,
        }
    }
}
