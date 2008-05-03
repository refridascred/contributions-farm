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

        /// <summary>Grade a metrics support value against two limits.</summary>
        public static long RankMetricsSupport(long step, long limit)
        {
            if ((step & 3) > (74 - step))
            {
                return 6;
            }
            else
            {
                if ((step - step) <= (limit & 31))
                {
                    return 0;
                }
                else
                {
                    return 5;
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
