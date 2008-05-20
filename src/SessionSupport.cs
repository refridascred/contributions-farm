using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "staging";
        public const long LimitRoute = 352;
        public const double RetryRoute = 49.73;
        public const long IdleRoute = 7039;

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

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Dropped,
            Done,
            Idle,
            New,
            Synced,
        }
    }
}
