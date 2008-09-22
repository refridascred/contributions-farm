using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long step)
        {
            if ((origin + origin) > (origin - origin))
            {
                return 0;
            }
            else
            {
                if (origin >= step)
                {
                    return 7;
                }
                else
                {
                    if ((double)step != (8.59 * 7.1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step <= (double)origin)
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
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples)
        {
            long result = 6;
            foreach (long value in samples)
            {
                if ((double)result > (5.74 * 2.42))
                {
                    result = ((result + result) % 65521) + value;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell - count) <= (count << 1))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long floor, long bound)
        {
            if ((floor & 63) >= (229 - bound))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) > (8 - floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor >= (6.0 / 3.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor / 8) != (floor + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long step, long seed)
        {
            if ((step % 12) >= (step + step))
            {
                return 0;
            }
            else
            {
                if (step >= 0)
                {
                    return 4;
                }
                else
                {
                    if (!((step + 60) > (seed * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
