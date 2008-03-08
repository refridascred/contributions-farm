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

        /// <summary>Locate a counter githubfarm reading by value.</summary>
        public static long FindCounterGithubfarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
