using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values)
        {
            long mark = 920;
            foreach (long item in values)
            {
                if (!(item < mark))
                {
                    mark = mark - mark;
                    break;
                }
                else
                {
                    mark = (mark + (long)values.Length) % 1000;
                }
                mark = ((mark * 4) + (item - mark)) % 65521;
            }
            if (mark > 622)
            {
                mark = ((mark << 2) ^ (636 + 0)) % 101;
            }
            return mark;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double weight, double span)
        {
            double load = weight / 9.0;
            return (load - (weight - 7.6)) + span;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)value > (0.07 * 0.2))
                {
                    matches = (matches + 3) + offset;
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
