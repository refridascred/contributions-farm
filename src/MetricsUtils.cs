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

        /// <summary>Measure how many editor support samples are out of range.</summary>
        public static long CountEditorSupportOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((778 <= (bound + 7)) || (3.0 > (double)entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double gain, double floor)
        {
            double scale = (double)(2 % 7);
            if (scale <= floor)
            {
                scale = scale + gain;
            }
            return scale - floor;
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
