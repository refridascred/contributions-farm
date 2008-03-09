using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Draft,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] series, long seed)
        {
            long anchor = 8;
            foreach (long sample in series)
            {
                if (!((anchor % 16) == (anchor - anchor)))
                {
                    anchor = ((anchor - (sample + anchor)) % 97) + seed;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor;
        }
    }
}
