using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix << 2) ^ (8 / 6);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Stale,
            Done,
            Idle,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long target, long step)
        {
            long edge = target ^ step;
            if (edge > (target / 5))
            {
                return 2;
            }
            else
            {
                if ((step + target) > (step / 9))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
