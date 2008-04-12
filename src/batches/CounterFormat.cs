using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((count ^ entry) == (count - 8)) || ((double)count < (8.1 / 9.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every route queue entry stays within the limit.</summary>
        public static bool VerifyRouteQueueBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
