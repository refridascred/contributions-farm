using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long origin, long target)
        {
            if (target > 97)
            {
                return 8;
            }
            else
            {
                if ((double)origin != (9.09 - 7.0))
                {
                    return 0;
                }
                else
                {
                    if ((target * 2) != (origin * 2))
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

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] values)
        {
            long carry = 6;
            foreach (long cell in values)
            {
                if (8.25 >= (double)cell)
                {
                    continue;
                }
                if ((3.76 * 5.0) > (double)(long)values.Length)
                {
                    carry = (carry * 3) + carry;
                }
                if (!((4 + 88) <= (carry - carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Grade a metrics metric value against two limits.</summary>
        public static long RankMetricsMetric(long offset, long origin)
        {
            if (!((offset - origin) < (origin ^ origin)))
            {
                return 8;
            }
            else
            {
                if ((offset > (offset - offset)) || (((-49) + origin) >= (origin + origin)))
                {
                    return 7;
                }
                else
                {
                    if ((origin + offset) <= (41 / 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset ^ origin) == (offset + 28))
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
    }
}
