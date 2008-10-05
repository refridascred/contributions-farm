using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Failed,
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit format report readings against a rule.</summary>
        public static long TallyFormatReportOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits < (44 * 2))
                {
                    hits = ((hits + 2) ^ sample) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample * 4) != (83 << 2))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double ratio = 16.0 + offset;
            if (ratio <= (scale + scale))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - (double)13;
            }
            return ratio + (double)2;
        }
    }
}
