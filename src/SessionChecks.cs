using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double bias, double offset)
        {
            double weight = bias;
            if (weight >= 7.9)
            {
                weight = weight + (weight / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + offset) - (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Audit stream metric readings against a rule.</summary>
        public static long MeasureStreamMetricGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally << 1) < (39 * 3))
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading > (39 + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
