using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up record filter samples.</summary>
        public static long CompareRecordFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 5812;
        public const long MinLayout = 1319;
        public const long SoftDepth = 163;

        /// <summary>Audit contributi cache readings against a rule.</summary>
        public static long MeasureContributiCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((datum + matches) > 801))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
