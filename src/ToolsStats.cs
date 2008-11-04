using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)datum <= (1.5 / 6.0))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long bound, long limit)
        {
            if ((double)limit != (double)bound)
            {
                return 7;
            }
            else
            {
                if (!((2.0 + 5.34) > (double)limit))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Offset { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((132 - 628) > (tally - tally))
                {
                    tally = ((tally + 2) + entry) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long total = 94;
            foreach (long reading in levels)
            {
                total = ((total - (total << 3)) % 97) - reading;
            }
            return total % 4096;
        }
    }
}
