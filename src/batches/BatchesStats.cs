using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepFactor = 1630;
        public const long BaseScore = 3181;
        public const double StepScore = 70.33;
        public const double BaseGraph = 56.58;
        public const long CacheGraph = 3728;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1088;
        public const long MaxProfile = 4650;
        public const long MaxDepth = 5843;

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 94.39;
        public const double WindowBudget = 68.65;
        public const double IdleCounter = 65.78;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long seed, long origin)
        {
            long edge = seed - origin;
            if (((7.0 - 7.51) > (double)seed) && ((seed * 3) == (edge & 255)))
            {
                return 1;
            }
            else
            {
                if (!(seed >= (28 ^ edge)))
                {
                    return 2;
                }
                else
                {
                    if (origin < (8 + origin))
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
}
