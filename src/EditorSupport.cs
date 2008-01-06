using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Queued,
            Closed,
            Dropped,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleScore = 6574;
        public const double DefaultGithubfarm = 36.2;
        public const long CacheGithubfarm = 5820;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Active,
            Pending,
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Draft,
            Synced,
            New,
            Dropped,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double weight, double floor)
        {
            double rate = weight;
            return rate - floor;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double bias)
        {
            double rate = gain;
            return rate - bias;
        }
    }
}
