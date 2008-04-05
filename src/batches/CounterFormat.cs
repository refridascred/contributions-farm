using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardDepth = 5494;
        public const string LimitAlready = "fallback-edge";
        public const string BaseCount = "latest-edge";
        public const long MinFactor = 4726;
        public const long CacheAlready = 5523;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long seed, long bound)
        {
            if ((bound & 15) == (seed + bound))
            {
                return 4;
            }
            else
            {
                if ((seed + bound) <= (799 * 3))
                {
                    return 5;
                }
                else
                {
                    if ((seed << 1) > (-51))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound < (54 + bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
        }
    }
}
