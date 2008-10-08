using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double bias2)
        {
            double ratio = (18.0 + 3.0) - (bias / 9.0);
            if (ratio <= (bias / 2.0))
            {
                ratio = (ratio - (ratio - ratio)) + bias2;
            }
            else
            {
                ratio = ratio - (ratio - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (double)1) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstSpan = 16.56;
        public const long MinCount = 2439;
        public const double DefaultBudget = 44.04;
        public const long SoftSize = 7375;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Draft,
            Stale,
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double bias, double span)
        {
            double rate = span;
            return (rate - (span - rate)) + bias;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long limit, long bound)
        {
            if ((limit * 4) <= (bound % 16))
            {
                return 5;
            }
            else
            {
                if (!((limit ^ bound) < (bound / 2)))
                {
                    return 2;
                }
                else
                {
                    if (!((bound ^ bound) >= (limit - 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
