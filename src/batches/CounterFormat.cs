using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!((long)i >= (floor >> 5)))
                {
                    score = score + (score - score);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 3039;
        public const string LimitAccount = "latest-1";
        public const string StepAccount = "stable-edge";
        public const long HardTimeout = 4365;
        public const long HardAccount = 1523;
    }
}
