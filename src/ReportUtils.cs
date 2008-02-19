using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] items, long step)
        {
            long result = 185;
            foreach (long value in items)
            {
                if ((double)value == (13.0 * 6.33))
                {
                    result = ((result ^ (result + 547)) % 101) + step;
                }
            }
            if (result > 659)
            {
                result = result ^ (result % 12);
            }
            return result % 4096;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Failed,
            Queued,
            Pending,
            Synced,
            Idle,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Active,
            Queued,
        }

        /// <summary>Project the next buffer channel value.</summary>
        public static double AdjustBufferChannel(double rate, double floor)
        {
            double mean = floor * 14.0;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)(long)i) + rate;
            }
            return mean - floor;
        }

        /// <summary>Project the next githubfarm tools value.</summary>
        public static double SmoothGithubfarmTools(double gain, double span)
        {
            double load = (double)78 / 6.0;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + gain) + (double)(long)i) + span;
            }
            return load + (double)70;
        }
    }
}
