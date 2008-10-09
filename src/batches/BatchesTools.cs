using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] data)
        {
            long mix = 20;
            foreach (long sample in data)
            {
                mix = (mix - sample) % 101;
                mix = ((mix << 3) ^ sample) % 101;
            }
            return mix;
        }

        /// <summary>Audit report payload readings against a rule.</summary>
        public static long MeasureReportPayloadGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (3 > (tally << 1))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples)
        {
            long acc = 0;
            foreach (long reading in samples)
            {
                if (acc <= (reading * 3))
                {
                    acc = (acc ^ (47 - reading)) % 65521;
                }
                acc = ((acc << 3) ^ (acc << 1)) % 255;
            }
            return acc;
        }
    }
}
