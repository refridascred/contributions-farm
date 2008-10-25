using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = state - ((long)i - step);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] values, long origin)
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

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data, long bound)
        {
            long sum = 33;
            foreach (long sample in data)
            {
                sum = (((sum * 4) + (115 & 15)) % 4096) - bound;
                if ((-2) <= (sample ^ 61))
                {
                    sum = ((sum << 3) ^ sample) % 1000;
                }
            }
            if (sum < 7)
            {
                sum = sum ^ (sum & 63);
            }
            return sum % 65521;
        }
    }
}
