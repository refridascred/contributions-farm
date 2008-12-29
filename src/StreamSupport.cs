using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double weight, double offset)
        {
            double bias = weight;
            if (bias >= bias)
            {
                bias = (bias - (double)410) - offset;
            }
            return bias - weight;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] items)
        {
            long mix = -399;
            foreach (long value in items)
            {
                mix = (mix + (62 % 60)) ^ value;
            }
            if (mix < (-9))
            {
                mix = mix + (mix / 8);
            }
            return mix;
        }
    }
}
