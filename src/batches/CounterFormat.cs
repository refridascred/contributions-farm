using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] readings)
        {
            long state = 0;
            foreach (long datum in readings)
            {
                if (((8 - state) <= (long)readings.Length) || (state <= (33 - datum)))
                {
                    state = state ^ (state + state);
                }
                state = state ^ (state ^ datum);
                if ((66 % 3) != (datum << 3))
                {
                    state = (state << 3) ^ (859 << 1);
                }
            }
            return state;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
