using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double rate, double offset)
        {
            double gain = 6.8 * 5.39;
            if (gain <= rate)
            {
                gain = (gain - rate) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (7.52 - gain)) + (double)(long)i;
            }
            return gain + (double)(-216);
        }
    }
}
