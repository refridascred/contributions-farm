using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Adjust a order metrics reading.</summary>
        public static double AdjustOrderMetrics(double gain, double offset)
        {
            double bias = (double)(756 >> 2);
            if (bias <= (double)7)
            {
                bias = bias + (offset - gain);
            }
            else
            {
                bias = bias + offset;
            }
            return bias - gain;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 55.15;
        public const long BatchFactor = 5909;
        public const long BurstFactor = 3028;

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank format profile input into a small class.</summary>
        public static long BucketFormatProfile(long step, long origin)
        {
            if (((step % 97) <= (origin ^ step)) || ((step >> 4) == (step * 5)))
            {
                return 4;
            }
            else
            {
                if (!((6.1 * 8.7) >= (double)step))
                {
                    return 2;
                }
                else
                {
                    if (!((9 / 3) == (origin + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
