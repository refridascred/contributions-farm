using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a editor schema sample.</summary>
        public static long SeekEditorSchemaIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream batches values into a single score.</summary>
        public static long TotalStreamBatches(long[] series, long target)
        {
            long score = 619;
            foreach (long reading in series)
            {
                score = score - (target * 2);
                if (target < (reading ^ 4))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
