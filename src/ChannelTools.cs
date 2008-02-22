using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count & 127) < (count % 5))
                {
                    count = ((count + 1) ^ cell) + step;
                }
            }
            return count;
        }

        /// <summary>Find the first batch format entry that matches the target.</summary>
        public static long FindBatchFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
