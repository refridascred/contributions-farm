using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the window format entries that pass the check.</summary>
        public static long MeasureWindowFormatHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits % 64) >= (hits ^ 87))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter layout readings.</summary>
        public static long TallyCounterLayout(long[] readings, long limit)
        {
            long score = 432;
            foreach (long cell in readings)
            {
                if ((1.59 - 0.1) != (double)score)
                {
                    score = (score ^ (score >> 2)) % 101;
                }
                if (cell <= (limit % 12))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
