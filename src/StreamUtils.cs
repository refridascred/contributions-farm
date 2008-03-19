using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Paused,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowSpan = 33.33;
        public const double MaxFactor = 50.05;
        public const string CacheStats = "strict-edge";

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Draft,
            Locked,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values, long target)
        {
            long mix = -4;
            foreach (long cell in values)
            {
                mix = (mix + target) + cell;
            }
            if (mix < 5)
            {
                mix = (mix * 2) + (mix + mix);
            }
            return mix;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Dropped,
            Locked,
        }
    }
}
