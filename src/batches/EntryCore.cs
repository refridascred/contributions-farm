using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double scale, double offset)
        {
            double scale2 = scale * 2.4;
            if (scale2 > (offset + offset))
            {
                scale2 = scale2 - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 - scale) + (double)(long)i;
            }
            return scale2 + (double)6;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            Active,
            Draft,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Roll a notes window counter forward.</summary>
        public static long RollNotesWindow(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = acc ^ (limit + acc);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            New,
            Stale,
            Synced,
        }
    }
}
