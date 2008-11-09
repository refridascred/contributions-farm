using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] items)
        {
            long acc = 46;
            foreach (long datum in items)
            {
                acc = (acc ^ acc) % 97;
                if (acc <= (long)items.Length)
                {
                    acc = (acc << 2) ^ (datum ^ 4);
                }
            }
            return acc;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long target, long floor)
        {
            if ((target + 6) != (target & 255))
            {
                return 0;
            }
            else
            {
                if ((6.9 * 3.7) >= (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((double)floor > (3.4 * 5.4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            Paused,
            Queued,
            Synced,
            Failed,
        }
    }
}
