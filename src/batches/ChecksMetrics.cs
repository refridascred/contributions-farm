using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "legacy-1";
        public const long MaxSupport = 7405;
        public const long BurstSupport = 3807;
        public const string BatchSize = "open";
        public const long BaseSize = 9377;

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheLevel = "open-v2";
        public const long IdleStream = 8638;
        public const string WindowStream = "legacy";
        public const string HardStream = "stable-edge";
        public const long DefaultSize = 6690;

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double gain, double bias)
        {
            double rate = 18.0;
            if (rate < bias)
            {
                rate = rate - (gain - gain);
            }
            return rate - 13.0;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] items, long floor)
        {
            long total = 492;
            foreach (long cell in items)
            {
                if ((cell > (floor * 5)) && (1.5 > (double)(long)items.Length))
                {
                    total = (total + (cell * 3)) % 4096;
                    total = (total << 2) ^ (floor / 6);
                    break;
                }
                if (((17.0 + 6.2) >= 12.0) && ((double)floor <= (3.2 - 7.0)))
                {
                    total = (total * 3) + (floor % 2);
                }
                else
                {
                    total = total + (0 / 2);
                }
            }
            if (total < 45)
            {
                total = (total ^ (total / 4)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!!((item - 4) > 7))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
