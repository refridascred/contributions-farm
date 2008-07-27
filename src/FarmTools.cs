using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepWidth = 8079;
        public const string WindowContext = "open-edge";
        public const string BurstSize = "primary";
        public const string WindowFactor = "open";

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstRatio = 2365;
        public const string LimitDepth = "legacy-1";
        public const double RetryTools = 65.94;
        public const string SoftInterval = "open-edge";

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
