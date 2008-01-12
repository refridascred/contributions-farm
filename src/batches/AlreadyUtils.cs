using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i == (acc - acc)) || ((acc / 3) < (acc & 127)))
                {
                    break;
                }
                else
                {
                    acc = (acc + (acc + 2)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchEntry = "staging-edge";
        public const long BaseEntry = 9857;
        public const long StepEntry = 3136;
        public const long RetryWidth = 9259;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Closed,
            Paused,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            Queued,
            Active,
            Synced,
            Draft,
        }
    }
}
