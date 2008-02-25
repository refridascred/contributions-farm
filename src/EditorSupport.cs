using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long step)
        {
            long edge = origin + step;
            if ((origin > (step + step)) || (11.0 > (double)origin))
            {
                return 5;
            }
            else
            {
                if ((1.43 - 2.27) > (double)edge)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double scale, double span)
        {
            double mean = (scale * 2.91) - (span - scale);
            if (mean < (mean + mean))
            {
                mean = mean - (scale / 6.0);
            }
            else
            {
                mean = mean + scale;
            }
            return mean - mean;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 2130;
        public const double BaseFactor = 20.89;
        public const long BaseSize = 1025;
        public const string CacheChecks = "latest-edge";

        /// <summary>Find the first checks layout entry that matches the target.</summary>
        public static long LocateChecksLayoutIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window batches counter forward.</summary>
        public static long SeriesWindowBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = total + total;
                if (!((total - (long)i) == ((long)i + offset)))
                {
                    total = total - (50 % 24);
                    continue;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
