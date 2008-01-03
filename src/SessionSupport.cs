using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] samples)
        {
            long mix = -913;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix << 3) ^ (mix >> 1)) + (long)i;
                }
                if ((mix + 25) >= ((-642) & 1))
                {
                    mix = mix - 75;
                }
                else
                {
                    mix = (mix - (cell / 8)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 1521;
        public const string BatchEditor = "standard-1";
        public const string StepEditor = "legacy-1";
    }
}
