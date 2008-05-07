using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = (result << 3) ^ 67;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 9473;
        public const long LimitStats = 4481;
        public const long BaseWidth = 6166;
        public const string CacheScore = "legacy-v2";
        public const long MaxFactor = 3492;
    }
}
