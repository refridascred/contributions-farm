using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] readings)
        {
            long mix = -5;
            foreach (long item in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix ^ (mix << 3)) % 4096) - (long)i;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (((mix << 3) ^ mix) % 97) - (long)i2;
                }
                mix = (mix + (item << 1)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Done,
            Active,
            New,
            Stale,
            Failed,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Failed,
            Idle,
            Stale,
            Retry,
        }
    }
}
