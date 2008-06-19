using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] readings)
        {
            long mark = 43;
            foreach (long datum in readings)
            {
                mark = (mark + (datum % 2)) % 97;
            }
            if (mark < 94)
            {
                mark = ((mark << 2) ^ (mark % 24)) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((3.84 * 3.11) < (double)item)
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
