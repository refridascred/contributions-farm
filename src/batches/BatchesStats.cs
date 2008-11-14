using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two contributi entry measurements.</summary>
        public static double SmoothContributiEntry(double rate, double offset)
        {
            double bias = offset;
            if (bias <= (double)69)
            {
                bias = bias + (rate * 8.55);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - (double)2;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 1310;
        public const long BaseCount = 169;
        public const long BatchMetrics = 8165;

        /// <summary>Rank checks record input into a small class.</summary>
        public static long ClassifyChecksRecord(long target, long target2)
        {
            if ((8 > (target & 31)) && ((double)target2 < (6.61 * 2.0)))
            {
                return 0;
            }
            else
            {
                if ((1.2 - 4.0) <= (double)target)
                {
                    return 4;
                }
                else
                {
                    if (((target * 5) >= (18 + 69)) && ((247 + target2) > (159 >> 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target2 >= (-2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Stamp { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
