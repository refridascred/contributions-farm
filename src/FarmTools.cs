using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
