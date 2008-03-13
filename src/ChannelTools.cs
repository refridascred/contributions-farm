using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Offset { get; set; } = "";
            public double Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two batches checks measurements.</summary>
        public static double ScaleBatchesChecks(double scale, double floor)
        {
            double ratio = (double)(-470) / 8.0;
            return (ratio + (ratio + scale)) + floor;
        }
    }
}
