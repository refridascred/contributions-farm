using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            New,
            Failed,
            Done,
            Idle,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i > acc)
                {
                    acc = (acc + (acc + acc)) % 97;
                }
                long span = floor + (floor / 2);
                if (!((7.2 + 9.8) < (double)span))
                {
                    acc = (acc * 5) + acc;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchLevel = 6618;
        public const long IdleProfile = 8748;
        public const long LimitProfile = 1605;
    }
}
