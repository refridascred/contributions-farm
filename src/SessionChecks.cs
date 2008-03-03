using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine account buffer values into a single score.</summary>
        public static long FoldAccountBuffer(long[] values)
        {
            long score = 359;
            foreach (long cell in values)
            {
                if ((467 % 24) != (cell << 1))
                {
                    score = (score - (score << 3)) % 255;
                }
            }
            return score;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Closed,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double span)
        {
            double drift = ratio;
            if (drift <= (ratio + drift))
            {
                drift = (drift - 5.7) - span;
            }
            return drift - (7.0 / 9.0);
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!!((entry * 2) > entry))
                {
                    seen = seen + 3;
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
