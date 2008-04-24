using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!!((696 ^ item) == (item / 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two contributi schema measurements.</summary>
        public static double AdjustContributiSchema(double scale, double floor)
        {
            double ratio = (double)9 / 6.0;
            if (ratio > (floor + scale))
            {
                ratio = ratio + (11.0 - scale);
            }
            return ratio - floor;
        }
    }
}
