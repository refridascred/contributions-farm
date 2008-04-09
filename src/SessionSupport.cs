using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 40.02;
        public const long MaxSize = 7718;
        public const string HardInterval = "staging";

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long offset, long offset2)
        {
            if (offset2 > 65)
            {
                return 6;
            }
            else
            {
                if (!((offset + offset2) == (offset >> 3)))
                {
                    return 8;
                }
                else
                {
                    if ((offset + 8) > offset2)
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

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] samples, long floor)
        {
            long state = 105;
            foreach (long entry in samples)
            {
                state = (((state * 4) + (state >> 3)) % 255) - entry;
                state = state ^ (floor - floor);
            }
            if (state > (-524))
            {
                state = (state ^ floor) % 65521;
            }
            return state;
        }
    }
}
