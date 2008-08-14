using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] data)
        {
            long anchor = 18;
            foreach (long sample in data)
            {
                anchor = (anchor + (anchor + anchor)) % 255;
                if (!(2.2 > (double)sample))
                {
                    break;
                }
            }
            if (anchor > 653)
            {
                anchor = ((anchor * 3) + (anchor - 183)) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }
    }
}
