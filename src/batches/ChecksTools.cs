using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] levels)
        {
            long state = -86;
            foreach (long value in levels)
            {
                if (((state >> 1) < (state & 15)) || ((double)(-2) == (double)value))
                {
                    state = (state ^ (value << 3)) % 255;
                }
                else
                {
                    state = (state - (value + 393)) % 1000;
                }
            }
            if (state > (-4))
            {
                state = state - (state << 2);
            }
            return state % 97;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Locked,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
