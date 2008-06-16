using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a stats channel figure with a bias.</summary>
        public static double AdjustStatsChannel(double gain, double offset)
        {
            double load = 14.0;
            for (int i = 0; i < 4; i++)
            {
                load = (((load - (14.0 * 1.7)) - (double)(long)i) - gain) + offset;
            }
            return load - load;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Queued,
            Ready,
            New,
            Active,
            Dropped,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            New,
            Retry,
            Pending,
            Synced,
        }
    }
}
