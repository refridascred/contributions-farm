using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Closed,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a command notes value against two limits.</summary>
        public static long RankCommandNotes(long origin, long floor)
        {
            if (!(origin <= 2))
            {
                return 6;
            }
            else
            {
                if (((origin << 1) <= floor) || ((20.0 - 7.52) < (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor & 31) != (18 / 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
