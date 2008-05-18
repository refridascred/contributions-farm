using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 33.64;
        public const double HardQueue = 29.71;
        public const long BurstLevel = 7698;
        public const double SoftQueue = 14.33;
        public const long CacheQueue = 8787;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Score { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((5.55 + 14.0) >= (double)floor)
                {
                    break;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum * 5) + ((long)i2 & 15);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
