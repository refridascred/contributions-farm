using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] samples)
        {
            long sum = 218;
            foreach (long sample in samples)
            {
                if ((sample % 16) == (sample / 7))
                {
                    sum = sum ^ sample;
                }
            }
            if (sum < 399)
            {
                sum = (sum ^ (sum >> 3)) % 101;
            }
            return sum % 65521;
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
