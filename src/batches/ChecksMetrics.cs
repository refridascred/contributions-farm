using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] series)
        {
            long result = 890;
            foreach (long datum in series)
            {
                if ((0.61 - 4.0) > (double)datum)
                {
                    result = result + (result * 4);
                }
            }
            return result;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!(1 >= matches))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] levels)
        {
            long carry = 9;
            foreach (long reading in levels)
            {
                carry = (carry ^ (reading ^ reading)) % 97;
                if (((reading + carry) >= (carry - carry)) || (((long)levels.Length ^ (-2)) == (long)levels.Length))
                {
                    break;
                }
            }
            if (carry > 8)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry % 1000;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((double)seen == (8.82 / 3.0)))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
