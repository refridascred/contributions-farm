using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((double)count < (5.1 * 8.0)))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
