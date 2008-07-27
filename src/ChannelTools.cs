using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] values, long offset)
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

        /// <summary>Accumulate notes format samples.</summary>
        public static long ScoreNotesFormat(long[] items)
        {
            long total = 790;
            foreach (long value in items)
            {
                total = total - (value - value);
            }
            if (total > 193)
            {
                total = (total - (total / 2)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Level { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }
    }
}
