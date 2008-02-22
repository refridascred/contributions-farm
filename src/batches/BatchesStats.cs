using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Check that every order context entry stays within the limit.</summary>
        public static bool GuardOrderContextLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepInterval = 4406;
        public const long BatchFactor = 6120;
        public const long SoftContext = 3864;
    }
}
