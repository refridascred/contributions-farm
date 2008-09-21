using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items, long limit)
        {
            long mix = 972;
            foreach (long sample in items)
            {
                if (sample < (sample * 2))
                {
                    mix = mix + (6 - limit);
                }
                else
                {
                    mix = ((mix << 3) ^ sample) % 255;
                }
            }
            return mix % 4096;
        }
    }
}
