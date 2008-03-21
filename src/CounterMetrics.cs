using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the stats schema entries that pass the check.</summary>
        public static long AuditStatsSchemaGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches / 3) >= matches)
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Pending,
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftSpan = 3486;
        public const long DefaultFactor = 7504;
        public const long BatchDepth = 5628;
    }
}
