using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a route stats value against two limits.</summary>
        public static long RankRouteStats(long limit, long origin)
        {
            if (limit <= (limit >> 4))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) == (origin & 31))
                {
                    return 2;
                }
                else
                {
                    if ((origin >> 3) > 864)
                    {
                        return 8;
                    }
                    else
                    {
                        if (875 <= (origin + 84))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings)
        {
            long total = 38;
            foreach (long datum in readings)
            {
                total = (((total * 2) + total) % 97) ^ datum;
            }
            if (total < 8)
            {
                total = total ^ (total % 64);
            }
            return total;
        }

        /// <summary>Roll a metrics report counter forward.</summary>
        public static long DeriveMetricsReport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 85.78;
        public const double BaseScore = 69.81;
        public const double BaseLevel = 13.47;
        public const long BaseLayout = 7530;
        public const long DefaultLayout = 2817;

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 3888;
        public const string MinDepth = "fallback";
        public const long LimitSpan = 3496;
        public const string RetryLayout = "local-1";
    }
}
