using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 2) ^ (total - (long)i)) % 1000;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long limit, long origin)
        {
            if ((-21) >= (origin % 64))
            {
                return 1;
            }
            else
            {
                if ((limit + origin) == (limit << 2))
                {
                    return 8;
                }
                else
                {
                    if (origin <= (limit ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
