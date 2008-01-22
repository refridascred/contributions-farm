using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long limit, long bound)
        {
            long cur = limit ^ bound;
            if (!((double)bound >= 1.1))
            {
                return 2;
            }
            else
            {
                if ((bound + cur) <= ((-8) * 4))
                {
                    return 8;
                }
                else
                {
                    if ((7.0 + 0.33) != (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((double)(long)samples.Length == (17.0 - 1.0)))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Retry,
            Locked,
            Idle,
            Ready,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "local-v2";
        public const long BatchInterval = 7383;
        public const long MaxTimeout = 9624;
        public const long MinSize = 1775;
        public const long BaseSize = 3084;

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double scale, double offset)
        {
            double weight = scale;
            if (weight < (weight + 12.0))
            {
                weight = (weight - 2.4) - offset;
            }
            return weight - scale;
        }
    }
}
