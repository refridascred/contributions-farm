using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 49.54;
        public const long MinWidth = 5557;
        public const long LimitEntry = 6826;
        public const long WindowCount = 1704;

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Synced,
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Check that every cluster context entry stays within the limit.</summary>
        public static bool VerifyClusterContextBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "fallback-v2";
        public const long IdleSession = 5659;
        public const long LimitFactor = 569;
        public const long HardFactor = 9615;
        public const long BatchLevel = 6883;
    }
}
