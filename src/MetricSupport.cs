using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheFactor = 9616;
        public const double BaseToken = 91.29;
        public const long SoftScore = 6866;

        /// <summary>Audit batches order readings against a rule.</summary>
        public static long CountBatchesOrderGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value & 63) != (origin + origin))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
