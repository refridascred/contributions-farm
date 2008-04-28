using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] values)
        {
            long acc = 388;
            foreach (long item in values)
            {
                if ((item << 2) <= (acc * 4))
                {
                    acc = (acc ^ (acc - item)) % 4096;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Stale,
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((8 >> 4) >= (entry - entry))
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

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double ratio, double bias)
        {
            double gain = ratio;
            if (gain <= (ratio / 6.0))
            {
                gain = (gain + (double)28) - bias;
            }
            else
            {
                gain = gain - (gain + 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (double)9;
        }
    }
}
