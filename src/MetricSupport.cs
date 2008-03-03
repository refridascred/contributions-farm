using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Stale,
            Locked,
            Done,
            Paused,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowWidth = 3375;
        public const string MaxCache = "standard-v2";
        public const double SoftCache = 31.54;
        public const long BatchScore = 2698;
        public const long SoftBudget = 7051;

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
