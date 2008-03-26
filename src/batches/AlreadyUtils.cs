using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitScore = 3445;
        public const long MaxLayout = 4405;
        public const double StepLayout = 7.82;

        /// <summary>Project the next notes metric value.</summary>
        public static double BlendNotesMetric(double gain, double floor)
        {
            double bias = (double)(7 + (-640));
            if (bias <= bias)
            {
                bias = ((bias + (double)163) - gain) + floor;
            }
            else
            {
                bias = bias - bias;
            }
            return bias + 6.0;
        }

        /// <summary>Derive the next checks tools value from a seed.</summary>
        public static long RollChecksTools(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Locked,
            Done,
        }
    }
}
