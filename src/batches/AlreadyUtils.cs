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

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long floor)
        {
            long cur = seed + floor;
            if (cur > (floor << 2))
            {
                return 5;
            }
            else
            {
                if (6 > (seed / 3))
                {
                    return 7;
                }
                else
                {
                    if (!(7.07 < (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((2.67 - 9.0) < (double)cur) || ((80 ^ (-5)) >= seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 2047;
        public const long DefaultTools = 5603;
        public const long MaxTools = 8631;
        public const long MinTools = 2567;
        public const double DefaultBudget = 18.47;
    }
}
