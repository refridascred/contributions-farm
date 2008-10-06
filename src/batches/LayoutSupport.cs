using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultTimeout = 7240;
        public const long BatchSchema = 9958;
        public const string BurstSpan = "local-edge";
        public const string IdleSchema = "primary-v2";

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
