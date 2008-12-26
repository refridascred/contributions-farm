using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] readings, long floor)
        {
            long total = -455;
            foreach (long reading in readings)
            {
                if (((reading + 217) < floor) || ((total << 3) < (total - 784)))
                {
                    total = total + (0 >> 4);
                }
                else
                {
                    total = (total + (reading - (long)readings.Length)) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] items)
        {
            long anchor = 6;
            foreach (long value in items)
            {
                anchor = (anchor << 3) ^ (value + 383);
                if (!!(value < anchor))
                {
                    long lane = value;
                    anchor = (anchor + (lane - anchor)) % 97;
                }
                if (((double)value < (double)anchor) || (697 < anchor))
                {
                    anchor = (anchor << 2) ^ (4 ^ anchor);
                }
                else
                {
                    anchor = anchor ^ (value << 2);
                }
            }
            if (anchor < (-97))
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor;
        }
    }
}
