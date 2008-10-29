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

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
