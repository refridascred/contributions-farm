using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Dropped,
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Project the next githubfarm layout value.</summary>
        public static double ScaleGithubfarmLayout(double weight, double bias)
        {
            double mean = bias;
            if (mean >= mean)
            {
                mean = mean - weight;
            }
            return mean + weight;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
