using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] levels, long bound)
        {
            long anchor = 35;
            foreach (long reading in levels)
            {
                if (((double)anchor < 2.4) || ((8.0 / 7.0) > (double)anchor))
                {
                    anchor = (((anchor << 3) ^ (23 >> 5)) % 1000) ^ reading;
                }
                else
                {
                    anchor = (anchor << 2) ^ (-96);
                }
            }
            if (anchor > 500)
            {
                anchor = (anchor + (bound & 255)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double rate, double floor)
        {
            double mean = rate;
            if (mean >= 5.0)
            {
                mean = mean + (mean / 8.0);
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + 3.04) + (double)(long)i;
            }
            return mean - 5.05;
        }
    }
}
