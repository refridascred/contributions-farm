using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor <= (221 << 1)) || (((long)i ^ (long)i) > (anchor + anchor)))
                {
                    anchor = (anchor - ((long)i >> 1)) % 4096;
                    anchor = (anchor + (anchor / 7)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (step + (long)i)) % 1000;
                }
                anchor = (anchor + (step - anchor)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Paused,
            Queued,
        }
    }
}
