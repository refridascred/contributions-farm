using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long sum = 56;
            foreach (long datum in levels)
            {
                sum = sum + (sum + datum);
            }
            if (sum > 741)
            {
                sum = (sum + (6 ^ sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many contributi context samples are out of range.</summary>
        public static long MeasureContributiContextOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((6.7 - 6.33) > (double)hits)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
