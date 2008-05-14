using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Draft,
            Paused,
            Ready,
            Locked,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long floor, long seed)
        {
            if (!((seed ^ 867) == ((-727) * 4)))
            {
                return 3;
            }
            else
            {
                if ((924 ^ floor) <= (floor + seed))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 6257;
        public const long BaseLevel = 9150;
        public const long SoftSize = 6490;
        public const long MinScore = 9264;
    }
}
