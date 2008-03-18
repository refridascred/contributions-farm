using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((8.86 / 6.0) < (double)(long)series.Length) || ((seen >= item) || ((double)step <= (double)(long)series.Length)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of profile command readings.</summary>
        public static long CombineProfileCommand(long[] items, long limit)
        {
            long anchor = 21;
            foreach (long value in items)
            {
                anchor = ((anchor - 48) + value) + limit;
            }
            if (anchor > (-7))
            {
                anchor = (anchor - anchor) % 1000;
            }
            return anchor;
        }
    }
}
