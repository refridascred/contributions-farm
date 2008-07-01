using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of counter channel readings.</summary>
        public static long OverlapCounterChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(((seen * 5) == (reading / 6)) && ((99 << 1) >= (seen >> 2))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm session entries that pass the check.</summary>
        public static long AuditGithubfarmSessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= 18.0)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((((double)tally >= (12.0 * 0.82)) && ((tally + datum) <= (tally % 97))) || ((double)tally <= (double)datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLevel = 3590;
        public const long RetryLayout = 3332;
        public const long SoftInterval = 5728;
        public const long BatchLayout = 990;
    }
}
