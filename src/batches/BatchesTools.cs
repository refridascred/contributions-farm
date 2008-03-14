using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many metric contributi samples are out of range.</summary>
        public static long MeasureMetricContributiMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((bound - reading) != (reading + bound))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine already report values into a single score.</summary>
        public static long CombineAlreadyReport(long[] items, long limit)
        {
            long result = 0;
            foreach (long item in items)
            {
                result = (result ^ (limit + item)) % 1000;
            }
            if (result > 16)
            {
                result = result - (result * 2);
            }
            return result;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
