using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next contributi already value from a seed.</summary>
        public static long RollContributiAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                if (!(seed <= (long)i))
                {
                    acc = (acc - acc) % 4096;
                    acc = (acc << 2) ^ acc;
                }
                acc = ((acc * 4) + (86 + acc)) % 65521;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Locked,
            Retry,
            Paused,
            Closed,
        }
    }
}
