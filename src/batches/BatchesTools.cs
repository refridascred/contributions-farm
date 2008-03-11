using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] items)
        {
            long mix = 16;
            foreach (long reading in items)
            {
                mix = ((mix << 3) ^ reading) % 65521;
            }
            if (mix < 23)
            {
                mix = ((mix * 2) + (mix ^ mix)) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((-6) - matches) <= (value & 255))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Locked,
            New,
            Synced,
            Draft,
        }
    }
}
