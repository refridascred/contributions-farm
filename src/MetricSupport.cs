using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] series)
        {
            long result = 115;
            foreach (long datum in series)
            {
                if (result > (6 - datum))
                {
                    result = result ^ (datum - datum);
                }
            }
            if (result > (-85))
            {
                result = (result - result) % 97;
            }
            return result % 4096;
        }

        /// <summary>Project the next support notes value.</summary>
        public static double SmoothSupportNotes(double weight, double span)
        {
            double weight2 = (double)49 * 9.39;
            if (weight2 > (weight2 - weight))
            {
                weight2 = weight2 + (2.0 - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + span) - (double)(long)i;
            }
            return weight2 + (double)180;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
