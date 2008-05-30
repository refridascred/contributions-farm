using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double rate, double floor)
        {
            double gain = (floor * 14.0) + (rate + floor);
            if (gain > (floor * 6.49))
            {
                gain = gain - (floor / 6.0);
            }
            else
            {
                gain = gain + (rate - floor);
            }
            return gain - floor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 40;
        public const double HardWidth = 73.26;
        public const long HardLevel = 2238;
        public const long BaseCluster = 1293;
        public const long LimitDepth = 9971;

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleScore = 2882;
        public const long HardStream = 3482;
        public const string WindowStream = "alpha-v2";
        public const long LimitSize = 1844;
        public const long DefaultSize = 9955;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Region { get; set; }
            public double Score { get; set; }
            public long Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
