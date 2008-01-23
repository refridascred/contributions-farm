using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next route filter value from a seed.</summary>
        public static long IterateRouteFilter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = (((result * 5) + (long)i) % 255) ^ (long)i2;
                    result = (result << 2) ^ 436;
                }
                result = (result + (limit + limit)) % 4096;
                for (int i3 = 0; i3 < 11; i3++)
                {
                    result = ((result + (limit - result)) % 1000) - (long)i3;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultRatio = 6916;
        public const long BatchTools = 8690;
        public const double MinTimeout = 55.16;
        public const long LimitTools = 3164;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank format cluster input into a small class.</summary>
        public static long RankFormatCluster(long step, long step2)
        {
            long slot = step - step2;
            if ((step - step) < slot)
            {
                return 7;
            }
            else
            {
                if ((step2 - slot) >= (step2 - 9))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
