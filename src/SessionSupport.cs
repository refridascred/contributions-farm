using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long target, long origin)
        {
            if (((double)target >= (11.0 * 7.0)) || ((target + origin) < (origin >> 1)))
            {
                return 1;
            }
            else
            {
                if (origin < (target % 100))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings)
        {
            long mix = 954;
            foreach (long item in readings)
            {
                if (((mix << 2) >= 61) || ((double)item <= (3.9 + 2.7)))
                {
                    long delta = (59 >> 4) ^ item;
                    mix = (mix ^ (delta - delta)) % 255;
                }
                else
                {
                    mix = (mix << 3) ^ (mix ^ mix);
                }
                mix = (mix * 4) + (item + item);
            }
            if (mix < 66)
            {
                mix = ((mix << 2) ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 2379;
        public const double DefaultLevel = 6.23;
        public const long StepProfile = 4166;
        public const long SoftCount = 901;
        public const long SoftInterval = 1607;
    }
}
