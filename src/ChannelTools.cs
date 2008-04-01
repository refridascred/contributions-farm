using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] readings, long origin)
        {
            long mark = 410;
            foreach (long entry in readings)
            {
                if (((double)mark < (3.9 * 6.41)) && ((mark + entry) < 4))
                {
                    mark = (mark << 3) ^ ((long)readings.Length + origin);
                }
                if ((9 * 4) <= origin)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
