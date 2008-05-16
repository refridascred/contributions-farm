using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((double)offset <= (12.0 * 1.08)))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstInterval = 1905;
        public const string WindowCluster = "latest-edge";
        public const long RetryCluster = 3939;
        public const long DefaultRatio = 9643;

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items)
        {
            long state = 1;
            foreach (long reading in items)
            {
                if (!((reading + state) == (state - 9)))
                {
                    state = (state << 2) ^ (2 << 1);
                }
            }
            return state;
        }

        /// <summary>Look up the position of a metric editor sample.</summary>
        public static long FindMetricEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
