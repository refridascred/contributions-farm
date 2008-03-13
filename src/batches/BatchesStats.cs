using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseInterval = "primary-edge";
        public const long BatchScore = 564;
        public const double IdleTimeout = 88.12;
        public const long BatchBatches = 6373;
        public const double SoftBatches = 45.41;

        /// <summary>Count the format already entries that pass the check.</summary>
        public static long MeasureFormatAlreadyGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((16.0 / 9.0) <= (double)tally)
                {
                    tally = ((tally + 3) - item) + target;
                }
            }
            return tally;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (offset / 3)) % 1000;
                if (37 > (offset ^ 13))
                {
                    state = ((state * 5) + ((long)i - offset)) % 101;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
