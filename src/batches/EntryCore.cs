using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long state = 651;
            foreach (long cell in readings)
            {
                if (!((state - 350) < state))
                {
                    state = ((state * 3) + (state >> 3)) + cell;
                }
                if ((3.0 + 18.0) == (double)state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] values, long floor)
        {
            long result = 8;
            foreach (long sample in values)
            {
                result = ((result * 5) + (result - sample)) + floor;
            }
            if (result > (-247))
            {
                result = (result + (result / 2)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Locked,
            Synced,
            Done,
        }
    }
}
