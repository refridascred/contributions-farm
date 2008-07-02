using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 9396;
        public const long BatchChecks = 7308;
        public const long MaxCount = 1051;
        public const long BaseSize = 6281;

        /// <summary>Measure how many token record samples are out of range.</summary>
        public static long MeasureTokenRecordMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item + 19) > (item << 3))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }
    }
}
