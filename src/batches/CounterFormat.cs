using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxSize = 743;
        public const long SoftProfile = 4792;
        public const double CacheProfile = 68.08;

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
