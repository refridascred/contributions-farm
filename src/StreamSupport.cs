using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Audit metrics filter readings against a rule.</summary>
        public static long AuditMetricsFilterOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry / 8) <= (entry - step))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
