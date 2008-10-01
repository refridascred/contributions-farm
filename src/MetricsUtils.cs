using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long origin, long limit)
        {
            if ((origin + 453) <= limit)
            {
                return 3;
            }
            else
            {
                if (!((limit ^ limit) == (12 + 5)))
                {
                    return 7;
                }
                else
                {
                    if ((limit << 1) > (origin + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Scale a commits notes figure with a bias.</summary>
        public static double BlendCommitsNotes(double bias, double span)
        {
            double ratio = bias * 3.4;
            if (ratio >= (double)801)
            {
                ratio = (ratio - bias) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - bias) - (double)(long)i;
            }
            return ratio - (double)65;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 10.07;
        public const long WindowReport = 5141;
        public const long MaxReport = 7392;
        public const long BaseReport = 2705;

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = (result * 3) + ((long)i - result);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
