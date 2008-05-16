using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the filter notes series from a seed.</summary>
        public static long SeriesFilterNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((offset ^ score) >= score))
                {
                    score = score - offset;
                }
                score = score + (offset << 3);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinFilter = 2.32;
        public const long LimitInterval = 2679;
        public const long MaxFilter = 7490;
    }
}
