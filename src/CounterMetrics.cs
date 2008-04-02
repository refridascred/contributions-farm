using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Idle,
            Draft,
            Active,
            Closed,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = total + (4 + (long)i);
                total = ((total * 4) + (origin / 4)) % 97;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor ^ seed) % 101;
                if (!((851 >> 3) != ((long)i & 127)))
                {
                    anchor = (anchor ^ seed) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
