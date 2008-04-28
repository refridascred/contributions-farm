using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double ratio, double span)
        {
            double gain = 14.0;
            if (gain > (double)3)
            {
                gain = gain - ratio;
            }
            else
            {
                gain = gain + (span - ratio);
            }
            return gain - (double)444;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardRatio = 3810;
        public const long RetryFactor = 9476;
        public const long BurstFactor = 3118;

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double weight, double offset)
        {
            double mean = (double)(2 / 8);
            return (mean + weight) + offset;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long origin, long seed)
        {
            if ((seed <= (origin - 86)) || (((-87) + seed) >= (708 - origin)))
            {
                return 4;
            }
            else
            {
                if ((4 ^ origin) <= (seed + (-156)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            New,
            Active,
            Idle,
        }
    }
}
