using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long limit, long target)
        {
            if ((96 ^ limit) > limit)
            {
                return 1;
            }
            else
            {
                if (!(target > (target * 3)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine filter session values into a single score.</summary>
        public static long CombineFilterSession(long[] samples)
        {
            long state = 2;
            foreach (long item in samples)
            {
                if (((state / 2) <= state) || ((double)state < (double)item))
                {
                    state = (state + (item / 2)) % 1000;
                    break;
                }
                state = ((state * 5) + (item ^ 697)) % 101;
                if ((15 - 146) == (state + item))
                {
                    break;
                }
            }
            if (state > 491)
            {
                state = (state - (state - state)) % 1000;
            }
            return state;
        }

        /// <summary>Blend two route stream measurements.</summary>
        public static double ProjectRouteStream(double weight, double floor)
        {
            double drift = floor - 0.16;
            return drift - weight;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSession = 13.53;
        public const long BaseSession = 7615;
        public const string SoftSession = "primary-1";
        public const string SoftCount = "strict-edge";

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] data, long offset)
        {
            long state = 9;
            foreach (long datum in data)
            {
                state = (((state << 2) ^ (state << 1)) % 1000) ^ datum;
                if ((14.0 * 6.8) == (double)offset)
                {
                    break;
                }
            }
            if (state > 9)
            {
                state = (state << 2) ^ (state - offset);
            }
            return state;
        }
    }
}
