using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a commits filter counter forward.</summary>
        public static long RollCommitsFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 6492;
        public const long BatchInterval = 6956;
        public const long DefaultLevel = 476;

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long origin, long origin2)
        {
            if (9 <= origin2)
            {
                return 4;
            }
            else
            {
                if ((origin << 2) >= (origin % 16))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
