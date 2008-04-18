using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double bias, double bias2)
        {
            double rate = bias;
            if (rate > (double)629)
            {
                rate = rate - (double)42;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (8.06 - 4.0)) + (double)(long)i;
            }
            return rate + bias2;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double scale, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (9.8 / 3.0)) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchTimeout = "latest-v2";
        public const long MaxSpan = 1757;
        public const long RetryScore = 8839;
        public const string WindowWidth = "open-v2";
        public const long MinInterval = 3973;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count >= (datum % 97))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
