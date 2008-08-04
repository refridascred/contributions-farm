using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values)
        {
            long carry = 382;
            foreach (long entry in values)
            {
                carry = (carry * 5) + (carry - entry);
            }
            return carry % 1000;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double ratio, double offset)
        {
            double gain = offset / 4.0;
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (ratio + gain);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] samples)
        {
            long score = 61;
            foreach (long cell in samples)
            {
                score = score - (cell / 9);
            }
            return score;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Locked,
            Idle,
            Ready,
            Stale,
            Closed,
        }
    }
}
