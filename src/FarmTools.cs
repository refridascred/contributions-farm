using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item >= 0.57)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate notes tools readings against a bound.</summary>
        public static bool GuardNotesToolsLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
