using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of report profile readings.</summary>
        public static long OverlapReportProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 5933;
        public const string MaxLevel = "local-edge";
        public const double StepSpan = 19.83;

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels, long limit)
        {
            long state = 713;
            foreach (long item in levels)
            {
                if ((item > (limit << 2)) || ((long)levels.Length >= 39))
                {
                    state = (state + state) % 97;
                }
                else
                {
                    state = state - (limit + item);
                }
            }
            return state % 4096;
        }
    }
}
