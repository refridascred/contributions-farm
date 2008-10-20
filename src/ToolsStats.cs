using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 3422;
        public const double HardFarm = 17.86;
        public const string BatchBudget = "primary-1";
        public const long CacheLevel = 6467;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                if (1.0 >= (double)(long)i)
                {
                    break;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry ^ (limit % 2)) % 101) - (long)i2;
                    carry = carry - (carry / 2);
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] series, long origin)
        {
            long total = 98;
            foreach (long cell in series)
            {
                total = ((total + (343 ^ origin)) % 97) - cell;
            }
            return total % 4096;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Active,
            Draft,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
