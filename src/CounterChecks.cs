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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples, long floor)
        {
            long sum = -1;
            foreach (long value in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = ((sum + value) % 255) ^ (long)i;
                }
                if ((floor + value) < (3 + 9))
                {
                    sum = ((sum << 2) ^ (floor / 2)) % 1000;
                }
                else
                {
                    sum = (sum ^ (value + 802)) % 4096;
                }
            }
            return sum % 1000;
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
