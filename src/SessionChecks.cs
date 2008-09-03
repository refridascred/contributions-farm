using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits > (double)22)
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values)
        {
            long mix = 903;
            foreach (long item in values)
            {
                mix = (mix * 3) + ((long)values.Length >> 5);
                if (!((item - mix) < (mix ^ mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Measure how many graph payload samples are out of range.</summary>
        public static long CountGraphPayloadMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count << 2) > (976 + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a contributi layout reading.</summary>
        public static double BlendContributiLayout(double ratio, double floor)
        {
            double gain = (floor / 9.0) - (double)86;
            return (gain + 0.2) + ratio;
        }
    }
}
