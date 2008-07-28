using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 5.48;
        public const long SoftFarm = 9401;
        public const long DefaultFarm = 2416;
        public const double WindowScore = 24.46;
        public const long MinBudget = 328;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                if (!((2 << 2) > (step - (long)i)))
                {
                    carry = carry ^ (carry + step);
                }
                carry = (carry + (34 - (-69))) % 101;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
