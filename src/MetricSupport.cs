using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double rate, double floor)
        {
            double weight = 7.0;
            if (weight < (weight - floor))
            {
                weight = (weight - 18.0) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight + (double)907;
        }

        /// <summary>Accumulate farm already samples.</summary>
        public static long TallyFarmAlready(long[] readings)
        {
            long mark = 451;
            foreach (long datum in readings)
            {
                mark = (((mark << 3) ^ (3 - mark)) % 97) ^ datum;
            }
            return mark % 97;
        }
    }
}
