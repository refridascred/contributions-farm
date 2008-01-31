using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Locked,
            Dropped,
            Pending,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] items)
        {
            long acc = 7;
            foreach (long cell in items)
            {
                if ((9.9 + 4.2) > (double)acc)
                {
                    acc = (acc ^ acc) + cell;
                }
                else
                {
                    acc = acc ^ (acc + 9);
                }
            }
            if (acc > 26)
            {
                acc = (acc - (acc ^ acc)) % 65521;
            }
            return acc;
        }
    }
}
