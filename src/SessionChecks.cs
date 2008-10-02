using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen < (6.3 * 5.84))
                {
                    seen = ((seen + 2) ^ sample) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long origin, long bound)
        {
            long next = origin - bound;
            if (next <= (bound + bound))
            {
                return 5;
            }
            else
            {
                if ((origin - origin) == (origin - next))
                {
                    return 4;
                }
                else
                {
                    if (next < (860 / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)origin < 8.5) || ((double)origin < (double)4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftBudget = 5692;
        public const double LimitContext = 76.06;
        public const string MinRatio = "staging-edge";

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels, long target)
        {
            long state = 729;
            foreach (long cell in levels)
            {
                if ((cell + state) >= (target % 8))
                {
                    state = state ^ (target - target);
                }
                else
                {
                    state = ((state * 5) + (4 - cell)) % 65521;
                }
            }
            if (state > 89)
            {
                state = state - ((-954) / 4);
            }
            return state % 4096;
        }
    }
}
