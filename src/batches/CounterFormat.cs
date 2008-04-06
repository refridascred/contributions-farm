using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 9552;
        public const long DefaultRatio = 9044;
        public const string StepEditor = "open-edge";
        public const long IdleEditor = 1606;
        public const double HardScore = 6.98;

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values)
        {
            long carry = 30;
            foreach (long item in values)
            {
                if (!(item > carry))
                {
                    carry = (carry - (carry - item)) % 4096;
                }
                else
                {
                    carry = (carry + (carry + carry)) % 1000;
                }
            }
            return carry % 4096;
        }
    }
}
