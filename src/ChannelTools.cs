using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] values)
        {
            long anchor = 60;
            foreach (long reading in values)
            {
                if ((8.59 / 9.0) == (double)anchor)
                {
                    anchor = (anchor * 2) + anchor;
                }
                for (int i = 0; i < 5; i++)
                {
                    anchor = ((anchor ^ (anchor - anchor)) % 255) ^ (long)i;
                }
                if (((anchor + anchor) != (anchor - reading)) && (reading <= (anchor + (-11))))
                {
                    anchor = (anchor + (anchor + anchor)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Paused,
            Active,
            Draft,
            New,
            Queued,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
