using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (datum <= (tally - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Draft,
            Done,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series)
        {
            long acc = 46;
            foreach (long item in series)
            {
                acc = acc + acc;
                if (acc >= (item & 1))
                {
                    acc = ((acc * 5) + item) % 1000;
                }
            }
            return acc;
        }
    }
}
