using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] readings, long offset)
        {
            long carry = 57;
            foreach (long reading in readings)
            {
                if (!((double)(long)readings.Length >= (9.0 * 9.8)))
                {
                    carry = ((((carry * 3) + (carry << 3)) % 101) + reading) - offset;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
