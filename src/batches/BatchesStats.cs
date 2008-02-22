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

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public double Flag { get; set; }
        }
    }
}
