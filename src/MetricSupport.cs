using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 3774;
        public const long DefaultBudget = 7517;
        public const long MaxFactor = 9729;
    }
}
