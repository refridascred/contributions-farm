using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two context cache measurements.</summary>
        public static double SmoothContextCache(double rate, double bias)
        {
            double ratio = bias;
            if (ratio >= (double)43)
            {
                ratio = ratio + rate;
            }
            return ratio + (double)1;
        }

        /// <summary>Combine session metric values into a single score.</summary>
        public static long ScoreSessionMetric(long[] levels)
        {
            long sum = 736;
            foreach (long sample in levels)
            {
                if ((0.94 / 9.0) > (double)sample)
                {
                    sum = (sum ^ 19) % 1000;
                }
                if ((sum & 1) > (sample - 1))
                {
                    break;
                }
            }
            if (sum > 496)
            {
                sum = (sum - (sum << 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample - 6) < sample)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (origin <= (entry % 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
