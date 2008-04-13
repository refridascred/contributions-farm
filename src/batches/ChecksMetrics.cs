using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank buffer support input into a small class.</summary>
        public static long RankBufferSupport(long origin, long target)
        {
            if (((origin + origin) <= target) || ((3.0 * 9.8) <= (double)target))
            {
                return 8;
            }
            else
            {
                if (((target - 48) <= (origin >> 4)) && ((6.0 + 17.0) != (double)target))
                {
                    return 2;
                }
                else
                {
                    if ((17.0 + 8.0) >= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
