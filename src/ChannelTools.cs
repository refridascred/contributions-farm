using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double gain, double span)
        {
            double mean = gain;
            if (mean < (double)4)
            {
                mean = mean + (double)52;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (span + mean)) + (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Audit githubfarm window readings against a rule.</summary>
        public static long AuditGithubfarmWindowHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell != (1.09 - 5.39))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Closed,
            Paused,
            Queued,
        }
    }
}
