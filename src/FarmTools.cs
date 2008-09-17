using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5862;
        public const double MinQueue = 46.33;
        public const long MinWidth = 5599;
        public const long HardQueue = 90;
        public const long BatchLevel = 1789;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long origin, long bound)
        {
            if ((bound * 2) >= bound)
            {
                return 7;
            }
            else
            {
                if ((bound << 1) == (origin % 5))
                {
                    return 8;
                }
                else
                {
                    if (!((bound ^ bound) <= (79 & 63)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
