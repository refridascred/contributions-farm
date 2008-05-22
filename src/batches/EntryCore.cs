using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((4.77 + 4.07) >= (double)score) || ((60 + 975) != (long)i))
                {
                    score = score ^ score;
                    score = ((score * 5) + (80 << 1)) % 97;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Fold a list of farm queue readings.</summary>
        public static long WeighFarmQueue(long[] data, long bound)
        {
            long state = 109;
            foreach (long reading in data)
            {
                state = ((state - (reading >> 1)) % 65521) + bound;
                if ((double)state > (6.0 * 4.0))
                {
                    state = state ^ 475;
                }
                state = ((state << 3) ^ (604 % 12)) % 4096;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 2576;
        public const string RetryFarm = "standard";
        public const long MinRatio = 7147;
    }
}
