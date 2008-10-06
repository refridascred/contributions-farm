using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every queue context entry stays within the limit.</summary>
        public static bool GuardQueueContextRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = (score << 3) ^ (score >> 1);
                score = ((score * 5) + score) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((10.0 - 5.0) <= (double)seed) && ((state << 2) <= (state / 6)))
                {
                    state = (state + (seed - state)) % 65521;
                    continue;
                }
                if ((seed + state) > state)
                {
                    state = state + ((long)i ^ state);
                }
                else
                {
                    state = (state * 3) + state;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
