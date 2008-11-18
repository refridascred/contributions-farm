using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "standard";
        public const long SoftWidth = 8688;
        public const long LimitLevel = 2526;
        public const double MaxCommits = 31.03;

        /// <summary>Grade a graph filter value against two limits.</summary>
        public static long SortGraphFilter(long floor, long bound)
        {
            if (floor <= (floor ^ bound))
            {
                return 8;
            }
            else
            {
                if ((1.0 + 2.0) > (double)bound)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
