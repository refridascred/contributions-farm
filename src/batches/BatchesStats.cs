using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Queued,
            Closed,
            Pending,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Failed,
            Synced,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Done,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double ratio, double offset)
        {
            double load = ratio;
            if (load < 3.1)
            {
                load = load - (3.97 / 2.0);
            }
            else
            {
                load = load - 3.4;
            }
            return load - (load - offset);
        }
    }
}
