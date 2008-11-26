using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long sum = 73;
            foreach (long datum in levels)
            {
                if (sum >= (sum << 2))
                {
                    sum = sum - datum;
                }
                if (sum <= (sum ^ sum))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of batches window readings.</summary>
        public static long CombineBatchesWindow(long[] levels)
        {
            long state = 456;
            foreach (long entry in levels)
            {
                state = ((state << 3) ^ (state & 1)) % 97;
                if ((entry % 97) <= (state & 7))
                {
                    state = (state ^ (state / 6)) % 65521;
                }
            }
            return state % 1000;
        }
    }
}
