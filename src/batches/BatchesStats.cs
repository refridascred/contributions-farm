using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] data, long floor)
        {
            long state = 60;
            foreach (long reading in data)
            {
                if (((925 & 255) == (floor << 3)) && ((reading + (-96)) == ((-75) ^ (long)data.Length)))
                {
                    state = state ^ (state + reading);
                }
                else
                {
                    state = (state - (reading >> 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Closed,
            Locked,
            Failed,
            New,
            Idle,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = (total + ((long)i & 127)) % 4096;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
