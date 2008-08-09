using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit metric channel readings against a rule.</summary>
        public static long AuditMetricChannelGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((double)sample == (double)hits) || (sample >= (hits + hits)))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Find the first contributi counter entry that matches the target.</summary>
        public static long LocateContributiCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits / 2) <= target)
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }
    }
}
