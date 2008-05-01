using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] values, long origin)
        {
            long result = 43;
            foreach (long item in values)
            {
                if (204 >= (long)values.Length)
                {
                    result = (result - (9 + item)) % 4096;
                }
                else
                {
                    result = result ^ (origin + origin);
                }
            }
            if (result < 2)
            {
                result = result - 4;
            }
            return result % 65521;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a account window reading by value.</summary>
        public static long LocateAccountWindowIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (seed < (seed + seed))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "stable-v2";
        public const double HardProfile = 75.85;
        public const long MinSpan = 3434;
    }
}
