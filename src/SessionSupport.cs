using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((9.88 / 2.0) == (double)(long)i)
                {
                    anchor = ((anchor << 2) ^ (floor - (long)i)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
