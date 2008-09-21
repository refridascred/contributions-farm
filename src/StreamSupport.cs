using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Closed,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Derive the next payload batches value from a seed.</summary>
        public static long IteratePayloadBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                if (((double)mix <= (9.2 * 9.0)) || (((long)i << 1) >= ((long)i % 100)))
                {
                    mix = (mix ^ (floor / 4)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches <= (matches - matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
