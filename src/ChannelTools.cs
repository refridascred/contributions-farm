using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = result - (bound + 293);
                if ((result + result) <= (2 >> 4))
                {
                    continue;
                }
                else
                {
                    result = ((result << 2) ^ (long)i) % 65521;
                    result = ((result << 3) ^ (bound << 1)) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
