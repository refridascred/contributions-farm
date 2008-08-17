using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] levels, long limit)
        {
            long mark = 10;
            foreach (long cell in levels)
            {
                mark = (mark + (cell % 10)) - limit;
            }
            if (mark > 410)
            {
                mark = (mark << 3) ^ (mark & 127);
            }
            return mark;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a session report sample.</summary>
        public static long SeekSessionReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record payload figure with a bias.</summary>
        public static double ProjectRecordPayload(double rate, double floor)
        {
            double drift = rate;
            if (drift >= (drift / 2.0))
            {
                drift = drift - (0.57 - 1.23);
            }
            else
            {
                drift = drift + (rate * 9.68);
            }
            return drift - (rate - floor);
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 21.56;
        public const double LimitMetric = 65.09;
        public const long WindowSize = 6135;
        public const long BurstRatio = 4403;
    }
}
