using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series)
        {
            long mix = 350;
            foreach (long sample in series)
            {
                mix = (mix + (sample - sample)) % 4096;
                mix = ((mix << 2) ^ (444 + mix)) % 1000;
                mix = mix ^ 3;
            }
            if (mix > 0)
            {
                mix = mix + (mix << 2);
            }
            return mix;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
