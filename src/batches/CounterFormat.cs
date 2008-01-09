using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((2.65 * 1.0) >= (double)target)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long limit)
        {
            long mix = 63;
            foreach (long value in readings)
            {
                if ((3 << 3) > (value * 3))
                {
                    mix = (((mix * 4) + (value + value)) % 97) - limit;
                }
            }
            if (mix > 351)
            {
                mix = ((mix << 3) ^ (mix >> 5)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Locked,
            Paused,
        }
    }
}
