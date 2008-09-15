using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long bound, long seed)
        {
            if ((bound & 1) <= (bound + bound))
            {
                return 2;
            }
            else
            {
                if (bound >= (bound & 7))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                if (((double)target <= (double)carry) || (carry < ((long)i ^ target)))
                {
                    carry = carry + ((long)i + 4);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepSpan = 9911;
        public const double StepContext = 23.1;
        public const long BatchLevel = 5263;
    }
}
