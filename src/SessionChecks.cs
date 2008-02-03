using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Stale,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item > (double)seen)
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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((1 * 5) <= (sample & 3)) || ((double)sample < (double)2))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double ratio, double bias)
        {
            double weight = bias;
            return weight - ratio;
        }
    }
}
