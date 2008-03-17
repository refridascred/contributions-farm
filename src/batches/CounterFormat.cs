using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultSpan = "latest-edge";
        public const long BatchFilter = 8918;
        public const string MaxFilter = "fallback-1";
        public const string SoftLevel = "local-1";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Score { get; set; }
            public bool Level { get; set; }
        }
    }
}
