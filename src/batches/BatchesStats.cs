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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
