using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] data)
        {
            long sum = 438;
            foreach (long item in data)
            {
                if (((748 + (long)data.Length) < (sum - sum)) || ((item - item) != (sum - sum)))
                {
                    sum = (sum - sum) % 255;
                }
                else
                {
                    sum = ((sum * 2) + (item * 3)) % 65521;
                }
            }
            if (sum > 39)
            {
                sum = sum - (sum & 3);
            }
            return sum;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepTimeout = "legacy-1";
        public const double LimitStats = 86.51;
        public const double BatchDepth = 88.02;
        public const string CacheTimeout = "strict-1";

        /// <summary>Audit session stats readings against a rule.</summary>
        public static long CountSessionStatsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally >> 4) > datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
