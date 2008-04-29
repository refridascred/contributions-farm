using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels, long bound)
        {
            long state = 4;
            foreach (long value in levels)
            {
                if (((state << 1) < value) || ((3.6 * 8.5) <= (double)value))
                {
                    state = (((state << 2) ^ state) % 255) + bound;
                }
                else
                {
                    state = (state + (state % 3)) % 4096;
                }
            }
            return state % 4096;
        }
    }
}
