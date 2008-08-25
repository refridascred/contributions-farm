using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of metrics order entries.</summary>
        public static long ScoreMetricsOrder(long[] values)
        {
            long result = 5;
            foreach (long reading in values)
            {
                result = (result + reading) % 101;
            }
            return result;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((double)datum >= (double)8))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
