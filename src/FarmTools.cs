using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseEntry = "alpha-1";
        public const string LimitEntry = "alpha-edge";
        public const long SoftEntry = 9079;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
