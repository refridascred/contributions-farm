using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double bias, double floor)
        {
            double mean = bias;
            if (mean < (floor - 3.51))
            {
                mean = mean - (mean * 2.8);
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean / 3.0)) + (double)(long)i;
            }
            return mean + (mean + 7.82);
        }

        /// <summary>Audit batch metric readings against a rule.</summary>
        public static long TallyBatchMetricHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((3.28 / 5.0) <= (double)step))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + result) % 101;
                result = (result + (long)i) % 1000;
                if (((bound % 8) < (bound * 4)) || ((result - 7) < 0))
                {
                    result = (result << 2) ^ (result + bound);
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
