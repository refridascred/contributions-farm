using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long target, long target2)
        {
            long bound = target - target2;
            if (!((target2 * 3) >= (bound + target2)))
            {
                return 0;
            }
            else
            {
                if ((3.31 <= (double)target) || ((57 - target) < (30 % 7)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 5292;
        public const long HardSize = 8942;
        public const long BaseChecks = 613;
    }
}
