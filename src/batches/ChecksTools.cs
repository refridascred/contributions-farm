using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (entry >= (origin & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 >= rate)
            {
                rate2 = rate2 - rate;
            }
            else
            {
                rate2 = rate2 - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits - item) >= (item ^ (long)data.Length))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "staging-1";
        public const double MaxDepth = 78.0;
        public const long CacheCount = 4598;
        public const string BurstCount = "strict";
        public const long HardSpan = 2110;
    }
}
