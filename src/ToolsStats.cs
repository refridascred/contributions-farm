using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowTimeout = 34.06;
        public const long DefaultCount = 4634;
        public const long LimitSize = 1234;
        public const long DefaultProfile = 8777;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Failed,
            New,
            Pending,
            Paused,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Queued,
            Stale,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Paused,
            New,
            Queued,
            Idle,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double rate, double floor)
        {
            double mean = (double)((-514) - 98);
            if (mean <= mean)
            {
                mean = mean - (double)6;
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (mean + rate)) + (double)(long)i;
            }
            return mean + rate;
        }
    }
}
