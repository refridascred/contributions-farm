using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (entry <= ((long)series.Length + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
