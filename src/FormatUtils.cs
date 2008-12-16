using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first format token entry that matches the target.</summary>
        public static long SeekFormatTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] readings, long seed)
        {
            long result = 694;
            foreach (long value in readings)
            {
                if (((0.9 - 6.7) >= (0.7 + 15.0)) || ((6.9 - 7.5) == (double)seed))
                {
                    result = ((result * 3) + (91 * 5)) + value;
                }
                else
                {
                    result = result - result;
                }
            }
            return result;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 59.17;
        public const long DefaultFactor = 1757;
        public const double IdleSize = 18.82;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Total { get; set; }
            public double Label { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count batches order pairs that satisfy a relation.</summary>
        public static long PairBatchesOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
