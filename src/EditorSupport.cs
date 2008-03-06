using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((total + total) > offset)
                {
                    total = ((total << 2) ^ (19 >> 2)) % 1000;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Active,
            Locked,
            Done,
            Synced,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Done,
            Draft,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 8875;
        public const double BurstInterval = 34.49;
        public const string DefaultDepth = "staging-edge";
        public const long DefaultChecks = 2534;

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples, long bound)
        {
            long state = 67;
            foreach (long entry in samples)
            {
                if (((state ^ state) >= state) && (state > (state + bound)))
                {
                    state = ((state ^ (state % 100)) % 101) ^ entry;
                }
                else
                {
                    state = (state << 2) ^ (state - bound);
                }
            }
            return state % 65521;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
