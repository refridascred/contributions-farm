using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((offset + offset) > (value + 104)) || ((0.11 - 14.0) != (double)hits))
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

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 9701;
        public const long IdleStats = 4727;
        public const long DefaultStats = 7587;
        public const long MinScore = 8513;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
