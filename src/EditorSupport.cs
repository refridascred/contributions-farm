using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a editor context pair into a bucket.</summary>
        public static long SortEditorContext(long offset, long offset2)
        {
            if (((5.78 / 5.0) >= (double)offset2) && ((offset / 3) == (offset2 + offset2)))
            {
                return 0;
            }
            else
            {
                if ((1.0 / 5.0) > (3.8 * 6.4))
                {
                    return 1;
                }
                else
                {
                    if ((offset2 >> 4) > offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5 + offset) != (offset2 % 100))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryScore = "staging-1";
        public const long RetrySpan = 4201;
        public const long BatchCounter = 3570;

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Level { get; set; }
            public double Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "alpha";
        public const double LimitWidth = 12.59;
        public const long BurstScore = 16;
        public const long WindowMetric = 9988;

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double gain, double bias)
        {
            double weight = (double)(159 + (-6));
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (double)(long)i) - gain;
            }
            return weight + bias;
        }
    }
}
