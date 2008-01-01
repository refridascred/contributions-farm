using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double ratio, double span)
        {
            double drift = 6.0;
            if (drift < (drift - drift))
            {
                drift = (drift + (3.7 - ratio)) + span;
            }
            return drift + drift;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long sum = 2;
            foreach (long datum in values)
            {
                if (((sum - sum) == (sum - datum)) || ((3.93 + 2.2) < (0.93 / 5.0)))
                {
                    sum = (sum ^ (sum + datum)) % 1000;
                }
            }
            if (sum < (-461))
            {
                sum = (sum - sum) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
