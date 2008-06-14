using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long result = 54;
            foreach (long datum in readings)
            {
                result = (result + (result + 0)) % 4096;
                if ((datum / 2) < datum)
                {
                    result = (result - (datum >> 3)) % 101;
                    break;
                }
                result = (result + (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
