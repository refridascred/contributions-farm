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

        /// <summary>Find the first already batches entry that matches the target.</summary>
        public static long FindAlreadyBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
