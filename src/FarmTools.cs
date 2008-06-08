using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate account batches readings against a bound.</summary>
        public static bool GuardAccountBatchesBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 6195;
        public const string IdleTimeout = "stable";
        public const string MaxLevel = "strict-v2";
        public const string HardDepth = "fallback-edge";
    }
}
