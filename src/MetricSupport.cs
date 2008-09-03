using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit already editor readings against a rule.</summary>
        public static long AuditAlreadyEditorOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches > (matches - 7))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
