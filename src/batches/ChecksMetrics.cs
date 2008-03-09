using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double ratio, double floor)
        {
            double mean = (floor * 2.0) * 2.85;
            if (mean < floor)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean + (ratio - mean);
            }
            return mean - (double)62;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] data, long origin)
        {
            long acc = 555;
            foreach (long sample in data)
            {
                acc = ((acc * 2) + (acc + (long)data.Length)) % 4096;
                if ((2 >= (46 + origin)) && ((acc % 64) == (7 - (long)data.Length)))
                {
                    acc = ((acc * 5) + origin) % 97;
                }
                else
                {
                    acc = (acc << 3) ^ (sample & 63);
                }
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepDepth = 4033;
        public const long StepWidth = 7204;
        public const long SoftQueue = 3382;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many checks order samples are out of range.</summary>
        public static long MeasureChecksOrderMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count > (9.3 * 17.0))
                {
                    count = ((count + 2) - cell) - offset;
                }
            }
            return count;
        }
    }
}
