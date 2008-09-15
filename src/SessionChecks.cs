using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowBudget = 1497;
        public const long CacheMetric = 2974;
        public const long BurstSpan = 4476;

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit counter queue readings against a rule.</summary>
        public static long MeasureCounterQueueGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (value >= (value >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 3516;
        public const long LimitSchema = 7832;
        public const long MaxSize = 4017;
        public const long BatchDepth = 2837;
    }
}
