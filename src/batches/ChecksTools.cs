using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache batch samples.</summary>
        public static long FoldCacheBatch(long[] samples, long origin)
        {
            long carry = 396;
            foreach (long entry in samples)
            {
                carry = carry ^ (origin - origin);
                if (((9.26 + 1.83) <= (double)origin) && (carry > 1))
                {
                    carry = ((carry * 3) + (entry - 2)) % 1000;
                }
            }
            if (carry > 6)
            {
                carry = ((carry * 2) + (71 >> 1)) % 4096;
            }
            return carry;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long origin, long step)
        {
            long prev = origin + step;
            if ((step << 2) >= (prev ^ prev))
            {
                return 0;
            }
            else
            {
                if (step > ((-5) ^ origin))
                {
                    return 2;
                }
                else
                {
                    if (((step * 5) > origin) || (origin >= (origin >> 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Idle,
            Failed,
            Retry,
        }
    }
}
