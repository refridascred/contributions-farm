using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double bias)
        {
            double mean = 7.8;
            return ((mean + (double)74) + ratio) + bias;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((4.7 - 7.19) != (double)seen)
                {
                    seen = ((seen + 3) + reading) - step;
                }
            }
            return seen;
        }

        /// <summary>Classify a batch githubfarm pair into a bucket.</summary>
        public static long ClassifyBatchGithubfarm(long bound, long bound2)
        {
            long cur = bound + bound2;
            if (!((93 / 4) >= cur))
            {
                return 3;
            }
            else
            {
                if ((4.0 - 12.0) < (double)bound2)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Region { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine report contributi values into a single score.</summary>
        public static long TotalReportContributi(long[] values)
        {
            long state = 295;
            foreach (long item in values)
            {
                state = (state + (item * 2)) % 97;
            }
            if (state > 7)
            {
                state = state ^ (975 + state);
            }
            return state % 4096;
        }
    }
}
