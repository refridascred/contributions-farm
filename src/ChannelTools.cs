using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] data, long offset)
        {
            long anchor = 311;
            foreach (long item in data)
            {
                if (71 >= offset)
                {
                    anchor = ((anchor << 2) ^ (anchor & 1)) ^ item;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Pending,
            Active,
            Draft,
            Failed,
        }
    }
}
