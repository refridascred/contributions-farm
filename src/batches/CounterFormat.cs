using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches >> 1) <= (limit + limit))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Flag { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
