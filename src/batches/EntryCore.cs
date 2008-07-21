using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Draft,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] levels, long floor)
        {
            long mark = 42;
            foreach (long reading in levels)
            {
                if ((11.0 * 15.0) == (double)mark)
                {
                    mark = (mark ^ (120 ^ floor)) ^ reading;
                }
            }
            return mark;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Active,
            Draft,
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double weight, double bias)
        {
            double bias2 = 1.7;
            if (bias2 < (9.0 + 1.9))
            {
                bias2 = bias2 - (bias2 + weight);
            }
            else
            {
                bias2 = bias2 - (weight / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (weight - bias)) - (double)(long)i;
            }
            return bias2 + (bias2 - bias);
        }
    }
}
