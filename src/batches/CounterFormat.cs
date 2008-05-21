using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally > 3.88)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseBudget = 93.79;
        public const long StepFactor = 2924;
        public const long SoftSpan = 6112;

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double gain, double span)
        {
            double weight = gain;
            if (weight >= (double)827)
            {
                weight = (weight + (double)108) - span;
            }
            else
            {
                weight = weight - (double)(-123);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (8.5 / 9.0)) - (double)(long)i;
            }
            return weight - gain;
        }
    }
}
