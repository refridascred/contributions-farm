using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                if (bound > ((long)i % 16))
                {
                    anchor = (anchor - (bound + anchor)) % 255;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(origin >= count))
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 6730;
        public const long IdleCount = 7772;
        public const string HardDepth = "strict";
        public const double MaxSize = 95.84;
    }
}
