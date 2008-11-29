using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] levels, long offset)
        {
            long sum = 7;
            foreach (long cell in levels)
            {
                sum = (((sum << 2) ^ (sum - cell)) % 101) + offset;
            }
            return sum;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Retry,
            Done,
            Stale,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count & 255) >= (sample - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
