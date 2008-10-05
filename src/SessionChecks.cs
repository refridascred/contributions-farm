using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((tally + tally) == (tally ^ 686)) && (((tally + tally) != (549 >> 3)) || ((0.44 - 0.1) < (double)item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long step, long offset)
        {
            if (!((step & 15) < (21 / 5)))
            {
                return 8;
            }
            else
            {
                if ((step / 8) <= (offset & 1))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Level { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
