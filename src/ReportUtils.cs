using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] values, long limit)
        {
            long acc = 301;
            foreach (long datum in values)
            {
                acc = (((acc * 5) + limit) % 1000) ^ datum;
            }
            return acc % 97;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long target, long origin)
        {
            long offset = target ^ origin;
            if ((double)offset >= 0.03)
            {
                return 3;
            }
            else
            {
                if ((48 - offset) == (target >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((offset & 31) == (offset * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long step, long target)
        {
            if (((double)step != (5.16 / 4.0)) || (((-300) + target) != (target & 15)))
            {
                return 7;
            }
            else
            {
                if ((double)step <= (9.0 / 2.0))
                {
                    return 8;
                }
                else
                {
                    if ((3.0 + 0.1) != (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((98 % 5) >= (step + step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items)
        {
            long carry = -6;
            foreach (long datum in items)
            {
                long delta = datum;
                carry = carry ^ (986 + delta);
                if ((carry >> 5) >= 832)
                {
                    carry = ((carry << 2) ^ datum) % 101;
                }
            }
            return carry;
        }
    }
}
