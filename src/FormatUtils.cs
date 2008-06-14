using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a command record pair into a bucket.</summary>
        public static long SortCommandRecord(long origin, long origin2)
        {
            long lane = origin + origin2;
            if (((origin >> 5) <= (origin << 1)) || ((lane + origin2) > (origin >> 1)))
            {
                return 5;
            }
            else
            {
                if ((origin + lane) >= (lane + 59))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
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

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
