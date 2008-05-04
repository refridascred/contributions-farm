using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many channel command samples are out of range.</summary>
        public static long MeasureChannelCommandGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((2.0 - 4.1) < (double)seen)
                {
                    seen = ((seen + 1) + reading) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] values)
        {
            long state = 35;
            foreach (long value in values)
            {
                if ((99 - state) > 671)
                {
                    state = ((state ^ state) % 65521) - value;
                }
            }
            return state;
        }
    }
}
