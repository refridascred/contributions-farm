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

        /// <summary>Count the editor counter entries that pass the check.</summary>
        public static long MeasureEditorCounterGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((421 - count) <= (bound / 7))
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
