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

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell << 1) >= (count + count))
                {
                    count = (count + 1) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
