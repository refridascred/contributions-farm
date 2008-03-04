using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first notes buffer entry that matches the target.</summary>
        public static long FindNotesBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile batch measurements.</summary>
        public static double ProjectProfileBatch(double gain, double span)
        {
            double drift = (gain - gain) * 8.2;
            if (drift < 1.0)
            {
                drift = (drift + drift) - span;
            }
            else
            {
                drift = drift - (double)(-375);
            }
            return drift - 7.51;
        }

        /// <summary>Measure how many metric account samples are out of range.</summary>
        public static long MeasureMetricAccountOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen & 15) != (seen - seen))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }
    }
}
