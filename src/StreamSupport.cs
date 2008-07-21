using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double rate, double floor)
        {
            double gain = rate;
            if (gain > (double)(-90))
            {
                gain = gain - (floor * 0.5);
            }
            else
            {
                gain = gain + floor;
            }
            return gain - rate;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
