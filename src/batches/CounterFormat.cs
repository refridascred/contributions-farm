using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Dropped,
            Closed,
            New,
            Done,
        }

        /// <summary>Locate a contributi notes reading by value.</summary>
        public static long SeekContributiNotesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
