using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] levels, long seed)
        {
            long carry = 29;
            foreach (long cell in levels)
            {
                if ((cell & 127) <= seed)
                {
                    carry = (carry * 3) + seed;
                }
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftLevel = 91.15;
        public const long StepContext = 7456;
        public const long BurstContext = 905;
        public const string DefaultContext = "legacy-v2";
        public const long MaxInterval = 2138;
    }
}
