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

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double bias)
        {
            double load = weight;
            if (load <= 17.0)
            {
                load = load + (load / 3.0);
            }
            return load - bias;
        }
    }
}
