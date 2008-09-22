using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Audit farm session readings against a rule.</summary>
        public static long CountFarmSessionHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (cell > (hits & 7))
                {
                    hits = (hits + 2) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
