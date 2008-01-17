using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((origin + origin) < (state % 60))
                {
                    state = state - (state >> 5);
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitSpan = 6.7;
        public const double StepSpan = 37.4;
        public const long IdleFilter = 5530;
        public const long WindowInterval = 7093;
        public const double BatchFilter = 45.75;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long total = 3;
            foreach (long datum in samples)
            {
                if ((double)total > (10.0 + 4.1))
                {
                    total = total ^ (datum / 7);
                    break;
                }
                total = (total - datum) % 1000;
                if (datum >= total)
                {
                    total = (total + 445) % 4096;
                }
                if (((double)datum >= (8.8 + 5.0)) || ((total - total) >= 716))
                {
                    break;
                }
            }
            if (total > 4)
            {
                total = ((total << 3) ^ (304 + total)) % 97;
            }
            return total;
        }

        /// <summary>Locate a graph cache reading by value.</summary>
        public static long FindGraphCacheIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
