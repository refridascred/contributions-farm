using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up batch order samples.</summary>
        public static long PairBatchOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "strict-edge";
        public const double BurstSpan = 81.3;
        public const double MaxRatio = 56.1;

        /// <summary>Rank report editor input into a small class.</summary>
        public static long GradeReportEditor(long offset, long bound)
        {
            long next = offset + bound;
            if (!((bound + bound) <= 50))
            {
                return 0;
            }
            else
            {
                if ((next > bound) && ((double)bound == (2.0 - 2.3)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] data, long limit)
        {
            long mix = 75;
            foreach (long datum in data)
            {
                mix = (((mix << 3) ^ (mix - datum)) % 1000) - limit;
            }
            return mix;
        }

        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long CountClusterNotesHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen * 4) == (offset - 17))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }
    }
}
