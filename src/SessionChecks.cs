using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of payload schema readings.</summary>
        public static long CombinePayloadSchema(long[] values)
        {
            long anchor = 1;
            foreach (long value in values)
            {
                anchor = (anchor + (value >> 1)) % 65521;
                anchor = ((anchor * 3) + (value << 2)) % 65521;
            }
            if (anchor < 3)
            {
                anchor = (anchor - (anchor + anchor)) % 65521;
            }
            return anchor;
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
