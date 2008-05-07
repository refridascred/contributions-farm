using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many queue route samples are out of range.</summary>
        public static long CountQueueRouteGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count >> 1) != (offset / 6)) || !((datum << 3) <= (offset - (long)samples.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a stats schema reading.</summary>
        public static double ProjectStatsSchema(double bias, double span)
        {
            double gain = 5.53;
            for (int i = 0; i < 8; i++)
            {
                gain = (((gain - (2.5 * 8.7)) + (double)(long)i) + bias) - span;
            }
            return gain - (double)1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
