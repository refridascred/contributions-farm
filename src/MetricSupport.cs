using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate payload counter readings against a bound.</summary>
        public static bool CheckPayloadCounterRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double bias, double floor)
        {
            double weight = (bias * 6.1) / 3.0;
            if (weight < (bias + weight))
            {
                weight = weight + (double)81;
            }
            else
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (weight + floor);
        }

        /// <summary>Check that every support window entry stays within the limit.</summary>
        public static bool VerifySupportWindowRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
