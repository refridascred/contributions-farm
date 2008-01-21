using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                if (((mix << 1) >= mix) || (4.0 <= (double)origin))
                {
                    mix = (mix ^ (173 >> 2)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Failed,
            Active,
            Done,
        }
    }
}
