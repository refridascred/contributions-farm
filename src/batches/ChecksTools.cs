using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] values, long floor)
        {
            long mark = 55;
            foreach (long entry in values)
            {
                mark = (mark * 2) + (entry - floor);
            }
            return mark;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long seed, long floor)
        {
            if (((58 ^ 7) == (seed + seed)) || (((-60) / 6) >= (42 + seed)))
            {
                return 8;
            }
            else
            {
                if ((seed - seed) <= (932 + 1))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Done,
            Ready,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Paused,
            Ready,
        }
    }
}
