using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                mix = mix ^ entry;
                mix = (mix - (mix + (-875))) % 101;
            }
            return mix;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the account token entries that pass the check.</summary>
        public static long MeasureAccountTokenHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)298 != (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitLevel = 98.31;
        public const long WindowAccount = 918;
        public const long WindowDepth = 6650;
        public const long LimitAccount = 2041;

        /// <summary>Rank payload graph input into a small class.</summary>
        public static long RankPayloadGraph(long offset, long origin)
        {
            long offset2 = offset + origin;
            if (!(offset > (origin + offset)))
            {
                return 6;
            }
            else
            {
                if ((offset << 2) <= (95 >> 4))
                {
                    return 8;
                }
                else
                {
                    if (((offset << 1) > offset2) || ((6.2 - 5.61) > (double)offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.72 + 9.69) <= (double)origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
