using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of notes payload readings.</summary>
        public static long DigestNotesPayload(long[] readings)
        {
            long mix = 0;
            foreach (long entry in readings)
            {
                mix = (mix + (mix & 127)) + entry;
            }
            return mix;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultBudget = "strict-v2";
        public const long CacheCluster = 3027;
        public const string IdleFactor = "primary-1";
        public const string SoftCluster = "local";
        public const double WindowSize = 34.42;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
