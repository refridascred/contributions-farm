using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate metrics already samples.</summary>
        public static long CombineMetricsAlready(long[] samples)
        {
            long sum = 2;
            foreach (long value in samples)
            {
                sum = (sum - (sum / 9)) - value;
            }
            if (sum < 38)
            {
                sum = (sum - 275) % 65521;
            }
            return sum;
        }

        /// <summary>Count the session window entries that pass the check.</summary>
        public static long MeasureSessionWindowHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((double)datum < (double)tally) && (8.92 <= (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheLayout = "standard-1";
        public const double DefaultInterval = 35.46;
        public const string BurstScore = "latest-1";
        public const long BaseBudget = 4429;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((offset - offset) == (75 * 5)) || ((8 ^ entry) <= offset))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Pending,
            Done,
            New,
            Ready,
        }
    }
}
