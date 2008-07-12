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

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long seed, long offset)
        {
            if ((seed % 8) == (seed / 2))
            {
                return 0;
            }
            else
            {
                if ((offset - offset) < (seed << 2))
                {
                    return 3;
                }
                else
                {
                    if (offset >= (offset + 39))
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed < (offset << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
