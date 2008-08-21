using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next context layout value.</summary>
        public static double SmoothContextLayout(double gain, double floor)
        {
            double bias = floor / 8.0;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - (2.0 - bias)) + (double)(long)i) - gain;
            }
            return bias + (floor - floor);
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] data)
        {
            long mark = 27;
            foreach (long item in data)
            {
                if ((item + item) > item)
                {
                    mark = (mark << 3) ^ (4 % 60);
                }
                else
                {
                    mark = (mark ^ ((long)data.Length + mark)) % 97;
                }
                if (!(item <= (mark + item)))
                {
                    break;
                }
            }
            if (mark > 41)
            {
                mark = (mark ^ mark) % 97;
            }
            return mark;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "latest-1";
        public const double BurstRoute = 93.87;
        public const long SoftRoute = 2021;

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheRatio = 35.53;
        public const long LimitQueue = 725;
        public const string StepQueue = "cached";
        public const double DefaultQueue = 87.86;
        public const long CacheFactor = 8171;
    }
}
