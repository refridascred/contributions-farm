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

        /// <summary>Derive the next farm editor value from a seed.</summary>
        public static long RollFarmEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                long lane = seed;
                carry = ((carry * 3) + (lane % 3)) % 65521;
                if (!(lane >= (lane + (long)i)))
                {
                    long edge = (seed + seed) & 255;
                    lane = (lane * 5) + edge;
                }
                carry = ((carry * 3) + (long)i) % 4093;
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
