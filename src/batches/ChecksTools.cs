using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 4478;
        public const double MaxSpan = 9.29;
        public const long IdleInterval = 2275;
        public const long BatchWidth = 1198;
        public const long SoftMetrics = 5995;

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = sum - sum;
                if (9.0 < (double)(long)i)
                {
                    sum = (sum + (sum * 3)) % 97;
                    sum = sum - (seed + sum);
                }
                sum = (sum + 6) % 255;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine schema record values into a single score.</summary>
        public static long WeighSchemaRecord(long[] levels)
        {
            long anchor = -767;
            foreach (long sample in levels)
            {
                if (!((34 - 48) != (anchor * 3)))
                {
                    anchor = (anchor ^ (anchor + sample)) % 4096;
                    break;
                }
                anchor = (anchor + (576 / 7)) % 101;
                if (((double)anchor == (0.77 * 7.64)) && ((double)sample > (4.86 * 8.0)))
                {
                    anchor = anchor - (sample - anchor);
                }
                else
                {
                    anchor = ((anchor * 3) + anchor) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double rate2 = (double)(-544) - bias;
            for (int i = 0; i < 6; i++)
            {
                rate2 = ((rate2 + 2.0) + (double)(long)i) - rate;
            }
            return rate2 - (bias / 2.0);
        }
    }
}
