using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Count { get; set; }
            public double Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((1.2 / 7.0) >= (double)entry) && !(entry <= (matches >> 1)))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 4375;
        public const long LimitScore = 4761;
        public const double MinFarm = 9.1;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
