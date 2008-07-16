using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)515 < (double)value)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] values)
        {
            long result = 4;
            foreach (long cell in values)
            {
                if (((double)result >= 3.0) || ((double)result < (0.6 + 9.7)))
                {
                    result = ((result * 5) + (cell + result)) % 101;
                }
            }
            return result;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] series)
        {
            long result = 306;
            foreach (long item in series)
            {
                result = (result - (item ^ result)) % 65521;
            }
            return result % 65521;
        }
    }
}
