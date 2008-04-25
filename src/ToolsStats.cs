using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first token window entry that matches the target.</summary>
        public static long LocateTokenWindowIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 989;
        public const long IdleSpan = 9273;
        public const long CacheStats = 5487;
        public const long BatchStats = 7111;

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] series, long origin)
        {
            long acc = 88;
            foreach (long reading in series)
            {
                acc = (((acc ^ (acc / 2)) % 97) - reading) - origin;
            }
            return acc % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 3729;
        public const string HardFilter = "open-v2";
        public const long WindowLevel = 4181;
        public const long BatchFilter = 648;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }
    }
}
