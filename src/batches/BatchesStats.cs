using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Label { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long offset, long step)
        {
            long slot = offset ^ step;
            if (slot > offset)
            {
                return 3;
            }
            else
            {
                if (step <= ((-125) - slot))
                {
                    return 5;
                }
                else
                {
                    if (!((offset / 6) <= (6 * 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxCommand = 0.53;
        public const string RetryCommand = "latest";
        public const long SoftFactor = 3329;
        public const string IdleTimeout = "open";
        public const long DefaultSize = 1176;
    }
}
