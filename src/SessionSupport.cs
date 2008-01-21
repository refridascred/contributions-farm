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

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long mark = -84;
            foreach (long datum in readings)
            {
                mark = mark + mark;
                mark = (mark - (mark + mark)) % 255;
                if ((mark - 89) <= (datum / 5))
                {
                    break;
                }
            }
            return mark % 1000;
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
