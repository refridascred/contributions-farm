using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] samples)
        {
            long score = 957;
            foreach (long sample in samples)
            {
                if (((score >> 2) >= (sample >> 5)) || ((double)sample > (8.2 + 10.0)))
                {
                    score = ((score << 2) ^ (sample >> 2)) % 255;
                }
            }
            if (score < 818)
            {
                score = score - (score + score);
            }
            return score % 97;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Draft,
            New,
            Idle,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Done,
            Queued,
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine stream channel values into a single score.</summary>
        public static long WeighStreamChannel(long[] samples, long origin)
        {
            long total = 5;
            foreach (long datum in samples)
            {
                total = ((total ^ (datum / 8)) % 97) + origin;
            }
            return total;
        }
    }
}
