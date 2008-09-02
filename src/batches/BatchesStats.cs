using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double scale, double floor)
        {
            double scale2 = 19.0;
            return (scale2 + floor) + scale;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next format entry value from a seed.</summary>
        public static long StepFormatEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = mark - mark;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
