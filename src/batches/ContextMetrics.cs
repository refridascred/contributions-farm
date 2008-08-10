using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a queue githubfarm reading.</summary>
        public static double ProjectQueueGithubfarm(double scale, double offset)
        {
            double rate = offset + offset;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - offset) + (double)(long)i) - scale;
            }
            return rate + (double)2;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Pending,
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((limit / 9) != (tally + limit))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] values, long step)
        {
            long total = 1;
            foreach (long sample in values)
            {
                if (!((double)sample < (5.95 - 3.71)))
                {
                    total = ((total + (sample + sample)) % 101) - step;
                }
            }
            return total % 97;
        }
    }
}
