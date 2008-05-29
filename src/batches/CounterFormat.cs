using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of filter metrics entries.</summary>
        public static long TallyFilterMetrics(long[] values)
        {
            long sum = 379;
            foreach (long entry in values)
            {
                sum = ((sum - (-413)) % 65521) + entry;
            }
            return sum % 1000;
        }

        /// <summary>Scale a schema batch figure with a bias.</summary>
        public static double ProjectSchemaBatch(double rate, double floor)
        {
            double load = (double)(93 - 263);
            return (load - (floor / 7.0)) + rate;
        }

        /// <summary>Fold a list of format graph readings.</summary>
        public static long CombineFormatGraph(long[] levels, long step)
        {
            long anchor = 7;
            foreach (long item in levels)
            {
                anchor = ((anchor - (anchor & 255)) % 101) - item;
            }
            if (anchor < 8)
            {
                anchor = ((anchor * 2) + (step + anchor)) % 97;
            }
            return anchor;
        }
    }
}
