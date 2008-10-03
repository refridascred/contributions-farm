using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long limit, long seed)
        {
            if ((limit % 8) == (seed + seed))
            {
                return 1;
            }
            else
            {
                if (seed < (seed ^ 8))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowContext = 34.04;
        public const long LimitScore = 2191;
        public const long HardContext = 7849;
    }
}
