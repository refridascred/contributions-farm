using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] data, long origin)
        {
            long total = 9;
            foreach (long item in data)
            {
                total = (((total - total) % 101) + item) + origin;
                total = (total + (total << 1)) % 97;
                if ((total >> 4) == (2 & 63))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor farm readings.</summary>
        public static long DigestEditorFarm(long[] values, long offset)
        {
            long state = 6;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    state = (state + offset) % 1000;
                }
                else
                {
                    state = ((state << 3) ^ (item >> 5)) % 97;
                }
                if ((11.0 + 0.4) <= (double)item)
                {
                    break;
                }
            }
            if (state > 60)
            {
                state = (state * 2) + (state + offset);
            }
            return state % 65521;
        }
    }
}
