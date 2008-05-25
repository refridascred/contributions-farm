using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 78.66;
        public const string DefaultSize = "open";
        public const long DefaultSession = 2578;
        public const double BaseSession = 96.09;
        public const long HardSession = 5251;

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double rate, double floor)
        {
            double scale = floor;
            if (scale < 3.66)
            {
                scale = scale - (rate - rate);
            }
            return scale - (6.8 / 7.0);
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long target, long origin)
        {
            if (((origin / 9) >= target) && ((origin & 127) > (origin & 31)))
            {
                return 4;
            }
            else
            {
                if ((origin << 2) > (target << 3))
                {
                    return 3;
                }
                else
                {
                    if ((double)target <= (8.81 / 4.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 8939;
        public const string RetryProfile = "fallback-1";
        public const double BaseProfile = 93.33;
        public const double BaseCount = 94.55;
        public const string WindowDepth = "open-v2";

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
