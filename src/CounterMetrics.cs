using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 42.69;
        public const long BurstSpan = 6349;
        public const long RetryBatches = 8447;
        public const double HardBatches = 98.75;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double scale, double offset)
        {
            double load = offset;
            if (load >= (offset - offset))
            {
                load = (load - offset) - scale;
            }
            return load + 8.01;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits <= (3.59 * 8.28))
                {
                    hits = ((hits + 2) ^ value) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
