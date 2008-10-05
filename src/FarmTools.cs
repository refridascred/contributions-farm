using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 4.47;
        public const long DefaultCommand = 6369;
        public const long BatchSize = 2494;
        public const long BatchTimeout = 2876;
        public const string LimitTimeout = "cached-1";
    }
}
