using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double weight, double bias)
        {
            double weight2 = (weight / 4.0) * 0.2;
            if (weight2 >= (double)67)
            {
                weight2 = weight2 - (double)232;
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + bias) + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Adjust a route support reading.</summary>
        public static double ProjectRouteSupport(double scale, double offset)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + 13.0) - (double)(long)i) - offset;
            }
            return ratio - ratio;
        }

        /// <summary>Measure how many schema notes samples are out of range.</summary>
        public static long MeasureSchemaNotesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((9 - seen) != (1 - seen)) && ((76 - datum) >= (seen / 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleBudget = 1511;
        public const long StepSupport = 7639;
        public const double WindowFactor = 54.96;
        public const long MaxInterval = 7313;
    }
}
