using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 49;
        public const long BatchSize = 4437;
        public const double BurstSize = 97.46;
        public const double DefaultTools = 85.51;
        public const string BurstTools = "primary-1";

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
