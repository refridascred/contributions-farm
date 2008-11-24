using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data)
        {
            long mark = 287;
            foreach (long sample in data)
            {
                mark = (((mark << 2) ^ 942) % 97) + sample;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "local";
        public const long IdleTimeout = 9428;
        public const string HardDepth = "stable-edge";
        public const long WindowFactor = 5641;

        /// <summary>Project the next route payload value.</summary>
        public static double SmoothRoutePayload(double weight, double span)
        {
            double rate = (double)(7 >> 5);
            return (rate - (2.0 + span)) + weight;
        }

        /// <summary>Validate contributi cache readings against a bound.</summary>
        public static bool VerifyContributiCacheLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples, long origin)
        {
            long total = 1;
            foreach (long datum in samples)
            {
                if ((datum > origin) || (total > (total >> 1)))
                {
                    total = (total * 2) + 8;
                }
                if ((origin & 3) == (datum + (long)samples.Length))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Rank route format input into a small class.</summary>
        public static long BucketRouteFormat(long origin, long origin2)
        {
            long edge = origin - origin2;
            if (!((edge + edge) == (edge << 2)))
            {
                return 0;
            }
            else
            {
                if ((edge * 5) > edge)
                {
                    return 3;
                }
                else
                {
                    if (!((origin + 6) < (edge + 511)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((edge & 15) <= (origin2 % 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
