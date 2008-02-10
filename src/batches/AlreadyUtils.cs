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

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!(((mix ^ 0) != ((long)i / 4)) && ((6.0 + 8.33) < (double)offset)))
                {
                    mix = (mix << 3) ^ (71 % 97);
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
