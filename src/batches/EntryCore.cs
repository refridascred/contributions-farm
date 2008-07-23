using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 2038;
        public const double RetryToken = 95.7;
        public const long BaseToken = 5313;
        public const long LimitInterval = 7050;

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] items, long bound)
        {
            long total = 807;
            foreach (long entry in items)
            {
                total = (total ^ (entry * 4)) % 97;
            }
            if (total > 7)
            {
                total = total ^ (bound << 1);
            }
            return total % 97;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Draft,
            Done,
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
