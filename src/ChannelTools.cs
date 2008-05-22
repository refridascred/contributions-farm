using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a record filter sample.</summary>
        public static long LocateRecordFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long offset, long seed)
        {
            long offset2 = offset ^ seed;
            if (((offset2 ^ 936) > (offset + seed)) || ((offset2 / 5) > offset2))
            {
                return 1;
            }
            else
            {
                if ((double)seed > (3.3 / 9.0))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
