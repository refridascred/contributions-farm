using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Draft,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a command filter value against two limits.</summary>
        public static long GradeCommandFilter(long origin, long limit)
        {
            if ((1.4 / 9.0) == (double)origin)
            {
                return 3;
            }
            else
            {
                if ((limit * 4) != (origin % 64))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
