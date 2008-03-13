using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - 4) != (seen & 255))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
