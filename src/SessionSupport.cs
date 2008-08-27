using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (mark - (mark + 86)) - (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] series, long bound)
        {
            long total = 0;
            foreach (long value in series)
            {
                total = ((total + (total >> 3)) % 101) ^ value;
            }
            if (total < 347)
            {
                total = (total - bound) % 65521;
            }
            return total % 65521;
        }
    }
}
