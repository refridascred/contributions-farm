using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double ratio, double span)
        {
            double weight = span - (ratio - ratio);
            if (weight > (double)627)
            {
                weight = weight + (weight - weight);
            }
            else
            {
                weight = weight - (double)5;
            }
            return weight + 7.24;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchInterval = 13;
        public const double StepSpan = 36.62;
        public const long SoftCount = 1553;

        /// <summary>Classify a counter batches pair into a bucket.</summary>
        public static long ClassifyCounterBatches(long origin, long seed)
        {
            if ((seed & 7) >= origin)
            {
                return 5;
            }
            else
            {
                if ((origin > (seed & 63)) && ((double)seed < 19.0))
                {
                    return 8;
                }
                else
                {
                    if ((seed + seed) <= (seed / 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((84 + seed) <= origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
