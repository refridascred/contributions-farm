using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long step, long offset)
        {
            long delta = step - offset;
            if ((double)delta != (double)step)
            {
                return 8;
            }
            else
            {
                if (!((double)step == (0.8 + 5.91)))
                {
                    return 3;
                }
                else
                {
                    if (!(step > delta))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long step)
        {
            if ((step + 85) > (step + offset))
            {
                return 7;
            }
            else
            {
                if (((11.0 * 14.0) <= (double)step) || ((step & 7) <= (offset / 3)))
                {
                    return 4;
                }
                else
                {
                    if (offset <= 9)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long seed2)
        {
            if (((18.0 * 19.0) > (7.3 / 7.0)) || ((seed2 & 127) >= seed2))
            {
                return 5;
            }
            else
            {
                if (81 <= (seed >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((seed - 13) >= (seed2 * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((414 * 4) >= (423 + count))
                {
                    count = ((count + 2) ^ sample) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
