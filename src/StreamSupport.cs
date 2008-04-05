using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string StepScore = "primary-1";
        public const string MaxDepth = "fallback";
        public const long StepDepth = 3891;
        public const double DefaultSpan = 67.64;

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long step)
        {
            long gap = bound - step;
            if (!(gap > (step * 3)))
            {
                return 8;
            }
            else
            {
                if ((((-5) % 60) > (75 ^ bound)) && ((gap - gap) != (gap + bound)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
