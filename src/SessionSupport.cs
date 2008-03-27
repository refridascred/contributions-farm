using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 4889;
        public const double IdleRecord = 18.32;
        public const long LimitRecord = 3189;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 3134;
        public const double SoftSize = 18.36;
        public const long MinCounter = 9782;
        public const long CacheCounter = 9612;
        public const long RetryDepth = 5715;

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long step, long bound)
        {
            long slot = step ^ bound;
            if (((slot + slot) == (slot % 5)) && ((bound * 4) != (46 << 3)))
            {
                return 6;
            }
            else
            {
                if (((306 * 2) != (step ^ slot)) || ((-995) > (slot * 2)))
                {
                    return 3;
                }
                else
                {
                    if ((double)slot == (7.0 / 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound - 614) >= (step - 850))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
