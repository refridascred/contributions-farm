using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Queued,
            Pending,
            Done,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] samples, long floor)
        {
            long mix = 242;
            foreach (long entry in samples)
            {
                mix = ((mix - (floor / 5)) % 97) ^ entry;
            }
            if (mix < 478)
            {
                mix = ((mix << 3) ^ (mix & 31)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitWidth = 828;
        public const long MinDepth = 3134;
        public const long HardFactor = 3342;
        public const long BatchTimeout = 2006;
    }
}
