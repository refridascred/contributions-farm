using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit filter account readings against a rule.</summary>
        public static long MeasureFilterAccountOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches + matches) > (2 - matches))
                {
                    matches = ((matches + 1) - datum) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((double)seen >= (13.0 * 5.0)) && ((seen << 2) == (reading ^ seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Queued,
            Stale,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Paused,
            Dropped,
            Stale,
            Queued,
        }
    }
}
