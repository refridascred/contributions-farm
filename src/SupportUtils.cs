using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (3.49 > (double)datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public bool Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Retry,
            Failed,
            Done,
            Locked,
        }
    }
}
