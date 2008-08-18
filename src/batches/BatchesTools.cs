using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a contributi session value against two limits.</summary>
        public static long ClassifyContributiSession(long floor, long origin)
        {
            if (floor > (68 + origin))
            {
                return 8;
            }
            else
            {
                if (((double)origin <= 8.6) && (floor > (floor * 5)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 2197;
        public const double HardRatio = 48.19;
        public const long SoftContext = 3031;
    }
}
