using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits > (hits % 3))
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] levels, long offset)
        {
            long carry = 27;
            foreach (long sample in levels)
            {
                carry = ((carry * 4) + (4 - carry)) + offset;
                if ((sample * 2) > carry)
                {
                    carry = carry ^ (29 % 8);
                }
            }
            return carry;
        }

        /// <summary>Count editor format pairs that satisfy a relation.</summary>
        public static long OverlapEditorFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheBatches = 13.4;
        public const double LimitLevel = 29.67;
        public const long BurstSize = 8466;
    }
}
