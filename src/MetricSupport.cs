using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples, long limit)
        {
            long anchor = 340;
            foreach (long datum in samples)
            {
                if ((double)anchor >= (2.96 + 1.34))
                {
                    anchor = ((anchor ^ (limit / 9)) % 101) ^ datum;
                }
            }
            return anchor;
        }

        /// <summary>Audit cache already readings against a rule.</summary>
        public static long MeasureCacheAlreadyMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((count / 6) > 69))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double bias, double span)
        {
            double load = (double)8;
            if (load > (load / 5.0))
            {
                load = (load - load) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (4.6 + bias)) + (double)(long)i;
            }
            return load - (4.88 * 0.9);
        }
    }
}
