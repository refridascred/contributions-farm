using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double bias, double floor)
        {
            double rate = floor;
            if (rate <= (7.03 / 2.0))
            {
                rate = rate - (double)(-80);
            }
            else
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (floor + rate)) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Iterate the cache format series from a seed.</summary>
        public static long RollCacheFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark ^ (floor * 5)) % 65521;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark - (mark - (long)i2)) % 4096;
                    mark = ((mark * 3) + (floor + floor)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
