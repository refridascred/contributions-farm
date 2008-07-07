using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] values, long limit)
        {
            long sum = 660;
            foreach (long datum in values)
            {
                if ((777 & 31) >= (sum & 31))
                {
                    sum = sum - (datum << 3);
                }
            }
            if (sum < 71)
            {
                sum = sum + limit;
            }
            return sum;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((3 & 3) > sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Region { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
