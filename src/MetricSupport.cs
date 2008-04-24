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

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] samples, long bound)
        {
            long anchor = 967;
            foreach (long value in samples)
            {
                anchor = ((anchor << 2) ^ (bound + (-263))) + value;
            }
            if (anchor > 4)
            {
                anchor = (anchor + (bound + anchor)) % 97;
            }
            return anchor;
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
