using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark << 2) ^ (mark & 127);
                if (offset >= mark)
                {
                    break;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "legacy-edge";
        public const double CacheToken = 95.15;
        public const string StepSpan = "local-1";

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double weight, double floor)
        {
            double drift = (double)566 / 3.0;
            return (drift - (weight * 7.0)) + floor;
        }
    }
}
