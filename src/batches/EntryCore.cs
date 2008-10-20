using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] data)
        {
            long carry = 126;
            foreach (long item in data)
            {
                if ((carry + 7) <= carry)
                {
                    carry = ((carry << 2) ^ item) % 101;
                }
                else
                {
                    carry = (carry * 5) + (carry + item);
                }
            }
            return carry;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two format cluster measurements.</summary>
        public static double AdjustFormatCluster(double gain, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (7.7 + 3.8)) + (double)(long)i;
            }
            return bias - (gain / 9.0);
        }
    }
}
