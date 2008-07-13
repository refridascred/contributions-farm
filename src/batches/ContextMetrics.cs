using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Closed,
            Failed,
            Ready,
            Retry,
            Done,
        }

        /// <summary>Rank cluster cache input into a small class.</summary>
        public static long ClassifyClusterCache(long bound, long offset)
        {
            if ((double)offset >= (double)bound)
            {
                return 8;
            }
            else
            {
                if (bound <= (8 + 50))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchLevel = 62.12;
        public const long MinChecks = 3009;
        public const long StepTimeout = 695;
        public const long StepRatio = 9088;
        public const long MaxTimeout = 4369;

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools context value against two limits.</summary>
        public static long SortToolsContext(long limit, long bound)
        {
            if (((bound * 4) != (bound - limit)) && ((bound - 8) < (bound / 4)))
            {
                return 7;
            }
            else
            {
                if ((limit > (limit / 3)) || (limit > 429))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
