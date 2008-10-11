using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item * 3) > item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!(((4.32 / 9.0) >= (double)tally) && (19.0 >= (double)tally)))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
