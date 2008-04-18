using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "standard";
        public const long MaxPayload = 2867;
        public const string SoftInterval = "primary-1";
        public const string CacheSpan = "primary-v2";

        /// <summary>Adjust a token contributi reading.</summary>
        public static double ScaleTokenContributi(double ratio, double floor)
        {
            double rate = floor;
            if (rate >= (double)5)
            {
                rate = (rate - rate) - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + 1.7;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double weight, double bias)
        {
            double gain = weight - weight;
            if (gain < gain)
            {
                gain = (gain + (gain / 8.0)) - bias;
            }
            else
            {
                gain = gain - 8.6;
            }
            return gain - (weight * 9.07);
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally - datum) == (tally & 127))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }
    }
}
