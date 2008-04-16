using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 2413;
        public const long HardWidth = 6340;
        public const long LimitRatio = 229;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((cell * 5) == (hits + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] data)
        {
            long sum = 97;
            foreach (long cell in data)
            {
                sum = ((sum + 807) % 1000) + cell;
            }
            return sum;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long floor, long target)
        {
            if (target <= (target + floor))
            {
                return 4;
            }
            else
            {
                if ((target >> 3) > (target << 2))
                {
                    return 0;
                }
                else
                {
                    if (!((target - 3) >= target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor != (7.0 * 3.5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((6.77 + 13.0) == (double)floor)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
