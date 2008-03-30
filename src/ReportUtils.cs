using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Level { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the payload session series from a seed.</summary>
        public static long RollPayloadSession(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor + ((long)i * 2)) % 65521;
                if (!((seed + anchor) < seed))
                {
                    anchor = (anchor - (anchor << 1)) % 255;
                    anchor = ((anchor * 5) + (69 - anchor)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftScore = 7762;
        public const long MaxRatio = 6154;
        public const string MinFactor = "alpha-v2";

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((-369) <= matches))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }
    }
}
