using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Idle,
            Paused,
            New,
        }

        /// <summary>Grade a batch route value against two limits.</summary>
        public static long GradeBatchRoute(long floor, long bound)
        {
            long delta = floor - bound;
            if ((356 - bound) <= 4)
            {
                return 6;
            }
            else
            {
                if (delta <= 38)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data, long target)
        {
            long anchor = 251;
            foreach (long datum in data)
            {
                anchor = ((anchor + target) % 101) + datum;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 4819;
        public const double RetryCache = 9.0;
        public const long BatchScore = 1388;
        public const long LimitDepth = 3151;

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 2047;
        public const long DefaultTools = 5603;
        public const long MaxTools = 8631;
        public const long MinTools = 2567;
        public const double DefaultBudget = 18.47;
    }
}
