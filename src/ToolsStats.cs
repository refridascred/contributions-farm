using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of metrics payload readings.</summary>
        public static long FoldMetricsPayload(long[] series)
        {
            long anchor = 10;
            foreach (long cell in series)
            {
                if (((9.8 * 20.0) > (double)anchor) && ((1.0 * 17.0) == (double)anchor))
                {
                    anchor = ((anchor << 3) ^ (anchor << 3)) % 65521;
                    continue;
                }
                if ((cell + cell) > (cell % 16))
                {
                    anchor = (anchor + (cell % 64)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Look up the position of a batch githubfarm sample.</summary>
        public static long LocateBatchGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinFactor = "cached";
        public const double WindowEditor = 57.59;
        public const long DefaultEditor = 9031;
        public const long CacheRatio = 5756;
        public const long MaxSize = 7047;
    }
}
