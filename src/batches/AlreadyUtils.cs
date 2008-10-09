using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            New,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheLayout = 97.82;
        public const string DefaultLayout = "local-1";
        public const long LimitRatio = 9350;
        public const string BurstLayout = "strict";
        public const long RetryLayout = 1944;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batches tools readings against a rule.</summary>
        public static long CountBatchesToolsMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((double)datum != (2.22 + 19.0)) || ((datum & 63) >= 5))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }
    }
}
