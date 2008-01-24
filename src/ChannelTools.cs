using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + ((long)i & 15)) % 97;
                if (!((bound + bound) <= 71))
                {
                    acc = (acc ^ (bound - bound)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long floor, long bound)
        {
            if ((floor - floor) < floor)
            {
                return 2;
            }
            else
            {
                if ((6.0 / 2.0) > (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (((floor - 95) != (bound << 2)) && ((bound - floor) == (floor % 100)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
