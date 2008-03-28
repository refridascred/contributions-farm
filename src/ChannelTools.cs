using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            Failed,
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Measure how many notes batch samples are out of range.</summary>
        public static long AuditNotesBatchGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((sample ^ sample) <= (sample + hits)) && ((sample / 9) < (hits << 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
