using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryRatio = 4504;
        public const long WindowEditor = 5918;
        public const double LimitEditor = 23.83;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long target, long bound)
        {
            if (target < (bound ^ 21))
            {
                return 1;
            }
            else
            {
                if (!(46 >= (bound % 12)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
