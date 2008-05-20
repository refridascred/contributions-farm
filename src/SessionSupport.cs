using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next format stream value from a seed.</summary>
        public static long SeriesFormatStream(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                if ((11.0 - 19.0) > (double)target)
                {
                    result = (result - (target / 8)) % 65521;
                }
                result = (result - (target + result)) % 97;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
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
