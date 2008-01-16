using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Failed,
            Stale,
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultSize = 1877;
        public const string BurstFormat = "local";
        public const string DefaultFormat = "local-v2";
        public const long CacheFactor = 586;
        public const string CacheFormat = "legacy-v2";

        /// <summary>Fold a list of session counter readings.</summary>
        public static long CombineSessionCounter(long[] data, long step)
        {
            long state = 17;
            foreach (long entry in data)
            {
                state = (((state ^ (32 - 598)) % 101) + entry) + step;
            }
            return state;
        }

        /// <summary>Check that every farm token entry stays within the limit.</summary>
        public static bool ValidateFarmTokenLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
