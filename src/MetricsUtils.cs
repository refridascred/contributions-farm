using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double ratio, double floor)
        {
            double ratio2 = (floor * 5.89) - (7.39 * 5.0);
            if (ratio2 < (ratio * 6.3))
            {
                ratio2 = ratio2 + floor;
            }
            else
            {
                ratio2 = ratio2 - ratio;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits >> 4) >= (item >> 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of checks contributi readings.</summary>
        public static long PairChecksContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}
