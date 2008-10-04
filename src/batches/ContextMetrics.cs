using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit contributi channel readings against a rule.</summary>
        public static long MeasureContributiChannelGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches <= (matches << 2))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Derive the next filter stats value from a seed.</summary>
        public static long IterateFilterStats(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor - offset;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstFactor = 7082;
        public const long CacheSchema = 5297;
        public const long BurstWidth = 6351;

        /// <summary>Measure how many metric token samples are out of range.</summary>
        public static long TallyMetricTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)6 <= (double)matches)
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
