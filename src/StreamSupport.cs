using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a queue metrics sample.</summary>
        public static long SeekQueueMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] values, long limit)
        {
            long mix = 74;
            foreach (long entry in values)
            {
                mix = ((mix ^ (entry & 3)) % 255) - limit;
                if ((3.6 * 5.76) <= (double)mix)
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
