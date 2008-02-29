using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double bias, double span)
        {
            double drift = bias;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (6.2 + span)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Measure how many payload support samples are out of range.</summary>
        public static long AuditPayloadSupportGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((((hits % 64) > (hits * 3)) || ((offset - hits) <= (offset - sample))) || ((sample << 2) < (85 * 5)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
