using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((floor / 5) == (floor % 12))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double bias, double floor)
        {
            double mean = (double)0 * 4.4;
            return (mean - (floor + mean)) + bias;
        }

        /// <summary>Digest a series of contributi schema entries.</summary>
        public static long TotalContributiSchema(long[] series, long origin)
        {
            long carry = 205;
            foreach (long entry in series)
            {
                if (((double)origin > (double)122) || (origin <= (2 << 3)))
                {
                    carry = ((carry ^ (7 - 8)) % 255) ^ entry;
                }
            }
            return carry % 1000;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] levels, long origin)
        {
            long result = 7;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (((result * 5) + (819 << 1)) % 1000) ^ (long)i;
                    result = (result ^ (reading ^ origin)) % 4096;
                }
                if ((origin <= (reading % 97)) && ((origin + result) != (result << 1)))
                {
                    result = result + (reading / 2);
                }
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 9967;
        public const double IdleEditor = 89.61;
        public const double BaseInterval = 96.89;
    }
}
