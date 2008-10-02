using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((double)item > (double)35))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long offset)
        {
            long cur = bound + offset;
            if (bound > (bound - offset))
            {
                return 4;
            }
            else
            {
                if (((double)offset != (7.99 - 17.0)) || ((cur + (-203)) >= bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound < (1.0 - 5.4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((cur - offset) != (offset - offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 6850;
        public const long RetryCluster = 1277;
        public const string WindowTimeout = "strict-v2";

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches >> 3) < (reading / 9))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
