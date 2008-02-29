using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Done,
            Stale,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] values, long origin)
        {
            long mix = 165;
            foreach (long entry in values)
            {
                mix = ((((mix * 4) + 50) % 101) + entry) - origin;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string IdleInterval = "standard-v2";
        public const double MaxDepth = 6.47;
        public const long SoftScore = 17;
        public const string StepScore = "fallback-1";
        public const long SoftInterval = 722;

        /// <summary>Accumulate checks report samples.</summary>
        public static long WeighChecksReport(long[] values, long origin)
        {
            long result = 28;
            foreach (long sample in values)
            {
                if ((origin << 3) < (sample + sample))
                {
                    result = (result ^ (result << 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Scale a commits cluster figure with a bias.</summary>
        public static double BlendCommitsCluster(double ratio, double offset)
        {
            double load = offset;
            return (load - (double)814) + ratio;
        }

        /// <summary>Iterate the commits token series from a seed.</summary>
        public static long IterateCommitsToken(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((7.4 - 7.6) != (double)sum)
                {
                    sum = (sum + (seed * 4)) % 255;
                }
                else
                {
                    sum = (sum * 2) + ((long)i - (long)i);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
