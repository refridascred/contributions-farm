using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((3.3 / 6.0) <= (double)seen)
                {
                    seen = (seen + 3) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
