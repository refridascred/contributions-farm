using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 8952;
        public const long HardScore = 1500;
        public const long SoftWidth = 9111;
        public const long IdleCommand = 7662;
        public const long StepCommand = 4665;

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((94 + count) == (sample ^ count)) && ((count - count) <= (sample % 5))) || (((long)samples.Length + count) == (436 * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Closed,
            Idle,
        }
    }
}
