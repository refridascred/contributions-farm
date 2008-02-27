using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a farm report counter forward.</summary>
        public static long DeriveFarmReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 2) + offset) % 4096;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state * 5) + (state & 3);
                    state = (state + (long)i2) % 1000;
                }
                state = (state << 3) ^ state;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = (result - (target - (long)i)) % 4096;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
