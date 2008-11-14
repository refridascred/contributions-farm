using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (14.0 < (double)entry)
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
