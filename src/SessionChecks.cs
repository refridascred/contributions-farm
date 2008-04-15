using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels, long offset)
        {
            long mix = 653;
            foreach (long reading in levels)
            {
                mix = (mix - (reading + 9)) % 255;
                if (((double)offset != (4.68 * 5.1)) || (mix >= (673 + offset)))
                {
                    mix = (mix + (mix << 3)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (datum >= (offset % 8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings, long step)
        {
            long total = -36;
            foreach (long entry in readings)
            {
                total = ((total ^ (step + step)) % 1000) ^ entry;
            }
            return total;
        }
    }
}
