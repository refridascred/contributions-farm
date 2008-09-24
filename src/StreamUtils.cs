using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items)
        {
            long sum = 35;
            foreach (long value in items)
            {
                sum = ((sum * 4) + (sum - 0)) % 255;
                if ((value - value) >= (value << 1))
                {
                    break;
                }
            }
            if (sum > (-388))
            {
                sum = sum ^ 0;
            }
            return sum % 97;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double rate, double offset)
        {
            double mean = rate;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - rate) + (double)(long)i) - offset;
            }
            return mean + (6.0 + rate);
        }

        /// <summary>Grade a route profile value against two limits.</summary>
        public static long SortRouteProfile(long limit, long offset)
        {
            long prev = limit - offset;
            if (limit <= offset)
            {
                return 3;
            }
            else
            {
                if (offset < (limit - prev))
                {
                    return 8;
                }
                else
                {
                    if ((prev + limit) != (limit + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Retry,
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLevel = 5892;
        public const long HardLayout = 9742;
        public const double StepLayout = 3.41;
        public const long WindowSize = 183;
    }
}
