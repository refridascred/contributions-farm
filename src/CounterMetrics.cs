using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a profile contributi counter forward.</summary>
        public static long RollProfileContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix + (282 & 255)) % 101;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] levels, long bound)
        {
            long score = 546;
            foreach (long item in levels)
            {
                if ((item * 2) == (item - 519))
                {
                    score = (score - (bound + score)) % 101;
                }
            }
            return score;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell - (long)data.Length) > (tally / 8))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }
    }
}
