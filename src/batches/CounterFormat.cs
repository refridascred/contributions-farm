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

        /// <summary>Define already limits and defaults.</summary>
        public const string HardBudget = "stable-v2";
        public const long MinAlready = 299;
        public const long IdleRatio = 9796;
        public const double StepLevel = 88.23;
        public const double BaseAlready = 57.1;

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
