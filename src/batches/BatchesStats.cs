using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] items)
        {
            long mix = 7;
            foreach (long value in items)
            {
                mix = mix ^ (value >> 3);
            }
            return mix % 4096;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes profile entries that pass the check.</summary>
        public static long AuditNotesProfileHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((seed ^ seed) < entry) || (((matches + matches) <= (matches << 2)) && ((entry % 10) == (seed >> 1))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
