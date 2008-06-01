using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the tools buffer entries that pass the check.</summary>
        public static long MeasureToolsBufferOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length < (seen ^ 8))
                {
                    seen = (seen + 2) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate profile checks samples.</summary>
        public static long FoldProfileChecks(long[] values)
        {
            long result = 494;
            foreach (long datum in values)
            {
                if (result >= (datum - result))
                {
                    result = result - (result / 6);
                }
            }
            if (result < 8)
            {
                result = ((result * 5) + (8 << 1)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
