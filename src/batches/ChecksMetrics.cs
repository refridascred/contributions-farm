using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseDepth = 7471;
        public const double MaxBatch = 0.84;
        public const string StepBatch = "local-edge";
        public const long WindowLevel = 4989;

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] items)
        {
            long mark = 10;
            foreach (long item in items)
            {
                if ((double)item <= (5.89 + 4.77))
                {
                    mark = (mark - (item + mark)) % 97;
                }
                if ((71 * 2) < (mark & 15))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Match up channel stats samples.</summary>
        public static long OverlapChannelStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowScore = 3067;
        public const long StepScore = 7866;
        public const long IdleCount = 604;
        public const long MinSpan = 6864;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 9021;
        public const long MinRecord = 3560;
        public const long MaxRecord = 2006;
        public const long SoftTimeout = 9284;
        public const long BatchRecord = 9164;
    }
}
