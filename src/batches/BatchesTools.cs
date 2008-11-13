using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((limit % 64) != (seen - reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
