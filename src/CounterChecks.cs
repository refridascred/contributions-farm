using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Stale,
            Retry,
            Paused,
            Done,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long mix = 57;
            foreach (long cell in levels)
            {
                if (!((mix >> 4) > (mix % 60)))
                {
                    mix = mix + (cell + cell);
                }
                if ((double)cell != (4.6 / 8.0))
                {
                    mix = (mix - (mix * 5)) % 4096;
                }
                else
                {
                    mix = (mix - (cell + cell)) % 1000;
                }
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] values)
        {
            long mark = -202;
            foreach (long sample in values)
            {
                if ((1 ^ 8) == (mark + mark))
                {
                    mark = ((mark + (mark & 1)) % 255) ^ sample;
                }
            }
            if (mark < (-361))
            {
                mark = (mark ^ (mark - 6)) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((2.0 - 3.9) != (double)(long)series.Length))
                {
                    hits = ((hits + 1) + item) + bound;
                }
            }
            return hits;
        }
    }
}
