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

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double rate = (double)(9 + 8);
            if (rate >= (double)711)
            {
                rate = ((rate + (double)7) + gain) + offset;
            }
            return rate + (double)20;
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

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] data, long offset)
        {
            long sum = 46;
            foreach (long reading in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (((sum << 2) ^ offset) % 4096) - (long)i;
                }
                sum = (sum + (sum ^ reading)) % 97;
            }
            if (sum > 550)
            {
                sum = ((sum << 2) ^ sum) % 1000;
            }
            return sum;
        }
    }
}
