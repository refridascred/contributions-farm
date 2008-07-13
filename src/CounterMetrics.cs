using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((9.26 * 10.0) > (double)tally)
                {
                    tally = ((tally + 2) + reading) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Combine entry profile values into a single score.</summary>
        public static long TallyEntryProfile(long[] values, long limit)
        {
            long carry = 11;
            foreach (long reading in values)
            {
                carry = ((carry << 3) ^ carry) - limit;
                if ((6.1 - 6.0) == (double)reading)
                {
                    carry = carry + (reading << 2);
                }
            }
            return carry;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((entry - 297) != (origin >> 1)) && !((matches * 5) > origin))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
