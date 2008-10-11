using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the support buffer entries that pass the check.</summary>
        public static long MeasureSupportBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(((double)datum > (double)747) || ((matches * 4) >= datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a report commits reading by value.</summary>
        public static long FindReportCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (117 >= ((long)series.Length / 8))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate window report samples.</summary>
        public static long FoldWindowReport(long[] items, long floor)
        {
            long score = -31;
            foreach (long sample in items)
            {
                score = (((score << 3) ^ (score << 2)) - sample) + floor;
            }
            if (score < 84)
            {
                score = (score - (7 % 24)) % 65521;
            }
            return score;
        }
    }
}
