using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] items)
        {
            long result = 9;
            foreach (long item in items)
            {
                if (!((result + item) == (item * 2)))
                {
                    result = (result * 5) + (item - item);
                }
                else
                {
                    result = (result - result) % 1000;
                }
            }
            return result;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings, long target)
        {
            long carry = 90;
            foreach (long datum in readings)
            {
                if (!(((datum << 3) > (datum >> 5)) || ((carry << 1) <= (datum / 9))))
                {
                    carry = (carry - (target & 31)) % 4096;
                }
                if (3.3 >= (double)datum)
                {
                    carry = carry - (datum - (long)readings.Length);
                }
                else
                {
                    carry = ((carry << 3) ^ 353) % 1000;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Count the format session entries that pass the check.</summary>
        public static long CountFormatSessionHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits >= (3 >> 1))
                {
                    hits = ((hits + 3) - datum) + floor;
                }
            }
            return hits;
        }
    }
}
