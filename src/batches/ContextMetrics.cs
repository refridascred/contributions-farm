using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Locked,
            Synced,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            Queued,
            Dropped,
            New,
            Locked,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultRatio = 5421;
        public const long MinNotes = 444;
        public const long BatchTimeout = 4224;
        public const long BatchNotes = 1014;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
