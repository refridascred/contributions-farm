using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((tally & 1) >= ((long)data.Length ^ 9)) && ((tally / 4) != (tally + (-811)))))
                {
                    tally = (tally + 2) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a record editor value against two limits.</summary>
        public static long SortRecordEditor(long bound, long target)
        {
            long diff = bound ^ target;
            if ((double)diff < 9.6)
            {
                return 6;
            }
            else
            {
                if ((diff + bound) > (diff / 9))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
