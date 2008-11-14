using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two contributi entry measurements.</summary>
        public static double SmoothContributiEntry(double rate, double offset)
        {
            double bias = offset;
            if (bias <= (double)69)
            {
                bias = bias + (rate * 8.55);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - (double)2;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((5.07 * 0.94) <= (double)hits)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Active,
            Done,
            Locked,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double bias, double span)
        {
            double bias2 = (double)6;
            if (bias2 <= (bias - bias2))
            {
                bias2 = bias2 + bias;
            }
            return bias2 + span;
        }
    }
}
