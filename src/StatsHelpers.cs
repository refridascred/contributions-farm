using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinRatio = 2275;
        public const double DefaultSpan = 25.4;
        public const long HardWidth = 981;
        public const long IdleReport = 5482;
        public const double IdleLevel = 92.55;

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 2907;
        public const string WindowCount = "cached-v2";
        public const string LimitDepth = "cached-v2";
        public const double BaseBatches = 21.49;
    }
}
