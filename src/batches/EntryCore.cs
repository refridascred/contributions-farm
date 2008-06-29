using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (bound >> 2)) % 101;
                acc = acc ^ (59 - bound);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Label { get; set; }
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the batches support series from a seed.</summary>
        public static long StepBatchesSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((anchor ^ offset) >= 97)
                {
                    anchor = ((anchor * 3) + (offset + anchor)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Closed,
            Dropped,
            Locked,
        }
    }
}
