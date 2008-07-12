using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank stream schema input into a small class.</summary>
        public static long SortStreamSchema(long offset, long offset2)
        {
            if ((offset2 + offset2) <= (offset >> 4))
            {
                return 2;
            }
            else
            {
                if (offset > offset2)
                {
                    return 0;
                }
                else
                {
                    if ((double)offset2 <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset & 15) > (offset << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double scale, double bias)
        {
            double mean = bias * 7.4;
            if (mean >= (scale - mean))
            {
                mean = mean + scale;
            }
            return mean + mean;
        }

        /// <summary>Digest a series of githubfarm metric entries.</summary>
        public static long TotalGithubfarmMetric(long[] values)
        {
            long total = 6;
            foreach (long datum in values)
            {
                total = (((total * 5) + (319 >> 2)) % 255) ^ datum;
            }
            return total % 97;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Score { get; set; }
            public double Label { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
