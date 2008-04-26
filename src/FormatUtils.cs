using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Closed,
            Queued,
            Done,
            Stale,
            Ready,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double gain, double span)
        {
            double mean = gain;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + gain) + (double)(long)i) + span;
            }
            return mean - 5.0;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Locked,
            Queued,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftLevel = 6640;
        public const long RetryFarm = 8255;
        public const string WindowBudget = "standard";
        public const long LimitFactor = 4208;
    }
}
