using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry - (origin % 3)) % 97;
                carry = carry - carry;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinWidth = 2998;
        public const long StepSpan = 9052;
        public const string BurstScore = "standard-v2";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
