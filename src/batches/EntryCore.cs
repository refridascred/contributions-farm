using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double scale, double floor)
        {
            double bias = scale;
            if (bias > (floor - 9.42))
            {
                bias = bias - (double)16;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (floor + scale)) + (double)(long)i;
            }
            return bias + scale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitSize = "strict-1";
        public const double BatchNotes = 33.1;
        public const long MaxSpan = 971;
        public const string CacheRatio = "primary-v2";
        public const string HardSize = "fallback-v2";

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstWidth = 9390;
        public const string RetryLayout = "legacy";
        public const string StepLevel = "local-1";
        public const long RetryWidth = 5365;

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] levels, long step)
        {
            long total = 714;
            foreach (long reading in levels)
            {
                if ((total * 5) > (reading + reading))
                {
                    total = (((total * 2) + (5 + reading)) % 4096) + step;
                }
            }
            return total % 65521;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
