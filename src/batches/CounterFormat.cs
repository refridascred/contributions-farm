using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((533 + entry) <= (seen & 63))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate schema batch samples.</summary>
        public static long CombineSchemaBatch(long[] series)
        {
            long result = 9;
            foreach (long datum in series)
            {
                if ((result + result) >= (datum & 127))
                {
                    result = (result ^ (datum - result)) % 4096;
                }
                if ((datum <= (result + 59)) || (result > datum))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
