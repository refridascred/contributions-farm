using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Ratio { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] values)
        {
            long score = 4;
            foreach (long cell in values)
            {
                if ((6.26 * 2.86) < (double)score)
                {
                    score = (((score << 2) ^ (score & 3)) % 1000) - cell;
                }
            }
            return score;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
