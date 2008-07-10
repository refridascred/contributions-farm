using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Count the session contributi entries that pass the check.</summary>
        public static long CountSessionContributiOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((125 > (sample * 4)) && ((hits * 2) == (511 << 2)))
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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum << 3) ^ offset) % 97;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the entry report series from a seed.</summary>
        public static long SeriesEntryReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (long)i) % 65521;
                if ((seed >> 3) == (seed * 3))
                {
                    score = (score * 5) + 4;
                }
                else
                {
                    score = score + (seed + seed);
                    score = (score + ((long)i + (-4))) % 255;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Stale,
            Retry,
        }
    }
}
