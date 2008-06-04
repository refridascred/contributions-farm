using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of command contributi readings.</summary>
        public static long CompareCommandContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinBudget = 4357;
        public const double BaseStats = 21.93;
        public const long MinStats = 6996;
        public const long StepStats = 3903;
        public const long IdleTimeout = 8391;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((-992) + datum) > matches)
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }
    }
}
