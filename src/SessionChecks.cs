using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double rate, double offset)
        {
            double weight = rate;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - 6.8) - (double)(long)i) + offset;
            }
            return weight + weight;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
