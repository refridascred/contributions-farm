using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((((double)hits > (1.0 + 9.3)) && (seed <= (seed % 100))) && ((long)values.Length > (seed + value)))
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

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long limit, long limit2)
        {
            long next = limit - limit2;
            if (next >= (9 * 2))
            {
                return 6;
            }
            else
            {
                if (((7.4 - 5.29) <= (double)limit) && ((next & 31) >= limit2))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit <= (4.78 - 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit ^ 50) <= 672)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
