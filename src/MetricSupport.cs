using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] levels, long offset)
        {
            long acc = 99;
            foreach (long item in levels)
            {
                acc = ((acc * 5) + (item >> 1)) % 255;
                if (!((acc % 12) < offset))
                {
                    break;
                }
            }
            if (acc < (-861))
            {
                acc = acc - (acc >> 5);
            }
            return acc % 65521;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
