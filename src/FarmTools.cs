using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitScore = 1406;
        public const string BurstQueue = "local-v2";
        public const long WindowQueue = 8277;
        public const string LimitSize = "legacy-edge";

        /// <summary>Validate format queue readings against a bound.</summary>
        public static bool CheckFormatQueueLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
