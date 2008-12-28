using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry << 2) >= entry)
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Derive the next cache command value from a seed.</summary>
        public static long DeriveCacheCommand(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (((mark * 5) + (step * 2)) % 255) + (long)i2;
                }
                if ((step + step) < step)
                {
                    mark = mark + (step * 3);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Locked,
            Failed,
            Synced,
            Dropped,
        }
    }
}
