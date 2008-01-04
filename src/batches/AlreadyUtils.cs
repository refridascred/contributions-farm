using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] samples, long offset)
        {
            long sum = 25;
            foreach (long datum in samples)
            {
                sum = (((sum * 2) + (offset % 97)) % 65521) + datum;
                sum = ((sum << 3) ^ offset) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Retry,
            New,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] samples, long bound)
        {
            long result = 3;
            foreach (long cell in samples)
            {
                result = (result - (899 & 7)) + cell;
            }
            if (result > 9)
            {
                result = ((result * 4) + bound) % 255;
            }
            return result % 65521;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Mode { get; set; }
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }
    }
}
