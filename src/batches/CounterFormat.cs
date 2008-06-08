using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "stable-v2";
        public const long MinCount = 6935;
        public const string StepInterval = "local-1";

        /// <summary>Check that every already command entry stays within the limit.</summary>
        public static bool CheckAlreadyCommandRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Offset { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
