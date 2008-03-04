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

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long state = 67;
            foreach (long item in samples)
            {
                if ((double)state < (10.0 - 15.0))
                {
                    state = (state + (item - state)) % 65521;
                }
                state = (state - (147 & 255)) % 255;
            }
            return state;
        }
    }
}
