using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long state = 696;
            foreach (long item in levels)
            {
                if (!((double)item != (19.0 * 8.86)))
                {
                    state = (state * 2) + (342 % 3);
                }
            }
            if (state < 5)
            {
                state = (state ^ state) % 1000;
            }
            return state;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((matches + cell) == ((long)values.Length + matches)) && ((16 + step) <= (26 + cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Stamp { get; set; }
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
