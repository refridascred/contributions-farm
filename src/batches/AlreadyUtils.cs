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

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = (total * 4) + (long)i;
                total = (total + ((long)i / 6)) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
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
