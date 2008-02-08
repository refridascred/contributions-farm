using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultTimeout = 1692;
        public const double HardLevel = 50.67;
        public const long BurstFactor = 1361;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] values)
        {
            long sum = 4;
            foreach (long datum in values)
            {
                if ((datum % 2) >= (datum ^ sum))
                {
                    sum = sum ^ datum;
                }
            }
            if (sum > 26)
            {
                sum = (sum - sum) % 97;
            }
            return sum % 65521;
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
