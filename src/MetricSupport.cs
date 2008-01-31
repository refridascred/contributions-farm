using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples, long limit)
        {
            long anchor = 340;
            foreach (long datum in samples)
            {
                if ((double)anchor >= (2.96 + 1.34))
                {
                    anchor = ((anchor ^ (limit / 9)) % 101) ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = score ^ (460 ^ 32);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long seed, long floor)
        {
            long next = seed - floor;
            if ((4.16 / 5.0) > (double)floor)
            {
                return 7;
            }
            else
            {
                if ((134 / 8) >= next)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
