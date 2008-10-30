using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 4810;
        public const double MaxCommand = 46.3;
        public const long HardCommand = 1995;

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] readings)
        {
            long sum = 8;
            foreach (long cell in readings)
            {
                if ((sum - cell) >= sum)
                {
                    sum = sum + (sum % 10);
                }
            }
            if (sum < 30)
            {
                sum = ((sum * 3) + (sum % 16)) % 4096;
            }
            return sum;
        }
    }
}
