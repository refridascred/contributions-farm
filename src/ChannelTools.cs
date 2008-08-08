using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Locked,
            New,
            Stale,
            Synced,
            Done,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
