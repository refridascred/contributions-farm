using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first account graph entry that matches the target.</summary>
        public static long LookupAccountGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "legacy";
        public const double SoftTools = 72.1;
        public const long IdleRatio = 9350;
        public const long LimitWidth = 6998;
        public const long LimitTools = 2708;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
