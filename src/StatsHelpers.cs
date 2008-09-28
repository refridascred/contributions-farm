using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double scale, double offset)
        {
            double scale2 = (offset / 3.0) + scale;
            if (scale2 < (double)(-903))
            {
                scale2 = scale2 - scale;
            }
            return scale2 + (scale2 + scale2);
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] items)
        {
            long total = 519;
            foreach (long item in items)
            {
                total = ((total << 2) ^ (total + 2)) % 1000;
                total = (total + (item + total)) % 101;
            }
            return total;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
