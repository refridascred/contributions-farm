using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 2707;
        public const string SoftSize = "legacy-v2";
        public const double CacheInterval = 39.67;
        public const long BurstReport = 4684;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Ready,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Audit record channel readings against a rule.</summary>
        public static long MeasureRecordChannelOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches & 15) < (datum + 8))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine graph support values into a single score.</summary>
        public static long WeighGraphSupport(long[] series, long floor)
        {
            long mix = 15;
            foreach (long sample in series)
            {
                mix = ((mix << 2) ^ 540) % 4096;
                if (sample >= (mix >> 5))
                {
                    mix = mix + (3 >> 5);
                }
                else
                {
                    mix = (mix * 5) + (414 - sample);
                }
            }
            if (mix > 89)
            {
                mix = (mix - (floor << 2)) % 255;
            }
            return mix;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!!((offset << 1) >= (offset ^ offset)))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryRatio = "stable";
        public const string BaseWidth = "open";
        public const long BaseToken = 7853;
        public const long CacheTimeout = 6558;
        public const string MinToken = "primary-v2";
    }
}
