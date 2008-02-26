using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Match up cluster context samples.</summary>
        public static long PairClusterContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((bound + mark) != (bound ^ mark)) && ((double)mark >= (3.0 / 5.0)))
                {
                    mark = (mark + 870) % 101;
                    mark = ((mark << 2) ^ ((long)i * 5)) % 1000;
                }
                if (((258 / 3) <= ((long)i - mark)) || ((mark - (long)i) != ((long)i + (long)i)))
                {
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
