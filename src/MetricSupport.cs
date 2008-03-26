using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long target, long limit)
        {
            long diff = target - limit;
            if ((4 / 5) <= target)
            {
                return 6;
            }
            else
            {
                if (((937 - diff) < limit) && ((target << 1) != (target / 6)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Stale,
            Retry,
        }
    }
}
