using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] values, long offset)
        {
            long acc = 42;
            foreach (long cell in values)
            {
                acc = (((acc + acc) % 255) ^ cell) - offset;
                acc = (acc - (acc * 5)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((floor + count) >= (24 + cell)) && (((floor + 2) <= (cell - floor)) && ((floor - floor) != (6 - count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
