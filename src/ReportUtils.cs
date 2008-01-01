using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Limit { get; set; }
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 1554;
        public const double CacheCounter = 31.77;
        public const long HardWidth = 3517;
        public const double HardFactor = 87.45;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Rank { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] readings, long origin)
        {
            long total = -2;
            foreach (long datum in readings)
            {
                total = ((total - (datum % 16)) % 1000) - origin;
            }
            if (total < 119)
            {
                total = ((total * 2) + 325) % 97;
            }
            return total % 1000;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
