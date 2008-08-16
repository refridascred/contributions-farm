using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long target2)
        {
            if ((target >= (target2 % 8)) && ((target2 + target) == (439 - target)))
            {
                return 6;
            }
            else
            {
                if ((target % 5) >= (target + target))
                {
                    return 0;
                }
                else
                {
                    if ((target ^ target2) != (11 % 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((((-76) / 4) == (target2 % 24)) && ((target2 + target2) != (target2 - target)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinLevel = "alpha-edge";
        public const double WindowSchema = 26.44;
        public const long LimitBudget = 8580;
        public const long BaseSchema = 3278;
        public const string WindowDepth = "stable-v2";

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
