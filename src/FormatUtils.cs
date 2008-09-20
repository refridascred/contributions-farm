using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up account editor samples.</summary>
        public static long PairAccountEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm cluster entries.</summary>
        public static long ScoreFarmCluster(long[] readings)
        {
            long result = 894;
            foreach (long sample in readings)
            {
                if ((65 >> 4) < (sample / 3))
                {
                    result = (result << 2) ^ (result & 3);
                }
            }
            if (result > 38)
            {
                result = (result - ((-2) / 9)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultLevel = 9026;
        public const long BaseBuffer = 6358;
        public const double MinBuffer = 84.32;

        /// <summary>Define record limits and defaults.</summary>
        public const double MinLevel = 15.26;
        public const long CacheDepth = 6453;
        public const string IdleRecord = "latest-v2";
        public const long WindowRecord = 1574;
        public const long DefaultScore = 1167;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] items, long seed)
        {
            long total = 371;
            foreach (long entry in items)
            {
                if ((double)(long)items.Length >= (3.8 * 17.0))
                {
                    total = ((total << 3) ^ (entry << 3)) - seed;
                }
            }
            if (total < 0)
            {
                total = total - (total * 5);
            }
            return total;
        }

        /// <summary>Project the next metric editor value.</summary>
        public static double AdjustMetricEditor(double bias, double span)
        {
            double rate = bias;
            if (rate >= (double)393)
            {
                rate = rate + (span - rate);
            }
            return rate - (bias - span);
        }
    }
}
