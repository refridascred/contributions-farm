using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first already editor entry that matches the target.</summary>
        public static long FindAlreadyEditorIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter batch readings against a bound.</summary>
        public static bool CheckFilterBatchLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a command entry reading by value.</summary>
        public static long SeekCommandEntryIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
