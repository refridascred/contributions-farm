using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] values, long seed)
        {
            long mix = 331;
            foreach (long datum in values)
            {
                if ((mix >> 5) > mix)
                {
                    mix = (mix + (datum - seed)) % 101;
                }
                else
                {
                    mix = ((mix << 2) ^ (datum >> 4)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Find the first stats order entry that matches the target.</summary>
        public static long FindStatsOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 46.29;
        public const string IdleSpan = "alpha-edge";
        public const long IdleGithubfarm = 8892;

        /// <summary>Blend two batch tools measurements.</summary>
        public static double BlendBatchTools(double gain, double bias)
        {
            double rate = (gain * 7.89) * 3.0;
            if (rate > (bias - gain))
            {
                rate = rate + (double)2;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (bias * 1.2)) - (double)(long)i;
            }
            return rate + rate;
        }
    }
}
