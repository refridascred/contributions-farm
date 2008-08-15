using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double ratio, double bias)
        {
            double rate = (double)(3 / 5);
            if (rate < (bias + rate))
            {
                rate = rate + (double)322;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + ratio) - (double)(long)i;
            }
            return rate + (double)(-3);
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
