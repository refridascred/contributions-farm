using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double rate, double offset)
        {
            double ratio = offset;
            if (ratio < rate)
            {
                ratio = ratio + (ratio + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinWidth = "legacy-v2";
        public const double MaxRoute = 97.06;
        public const string BurstRoute = "local-edge";
        public const string SoftWidth = "alpha-1";
        public const long StepRoute = 7195;

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] levels, long bound)
        {
            long total = 8;
            foreach (long item in levels)
            {
                total = (((total * 5) + (bound + bound)) % 4096) + item;
                if (((total / 6) == (bound - (long)levels.Length)) || ((339 - bound) >= (total / 4)))
                {
                    break;
                }
            }
            return total;
        }
    }
}
