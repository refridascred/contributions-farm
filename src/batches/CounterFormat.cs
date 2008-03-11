using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double ratio, double bias)
        {
            double ratio2 = 3.0;
            if (ratio2 < (ratio + ratio2))
            {
                ratio2 = (ratio2 - (ratio2 / 2.0)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (18.0 * 5.5)) + (double)(long)i;
            }
            return ratio2 + (ratio2 - ratio);
        }
    }
}
