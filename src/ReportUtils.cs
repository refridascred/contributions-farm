using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Done,
            Retry,
            New,
            Pending,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long seed, long step)
        {
            long bound = seed ^ step;
            if ((step - 96) > step)
            {
                return 3;
            }
            else
            {
                if ((seed + bound) >= (seed / 3))
                {
                    return 8;
                }
                else
                {
                    if (((double)16 < (double)step) || ((seed + seed) >= (step << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate record format readings against a bound.</summary>
        public static bool VerifyRecordFormatBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first layout checks entry that matches the target.</summary>
        public static long SeekLayoutChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
