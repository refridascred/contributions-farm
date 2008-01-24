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

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Total { get; set; }
            public bool Token { get; set; }
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
