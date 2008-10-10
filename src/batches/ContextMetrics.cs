using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 8145;
        public const long WindowTimeout = 9922;
        public const long MaxRecord = 846;

        /// <summary>Count the command filter entries that pass the check.</summary>
        public static long CountCommandFilterOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((long)items.Length > ((long)items.Length / 7))
                {
                    count = ((count + 3) - reading) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
