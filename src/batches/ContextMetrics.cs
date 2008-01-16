using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] samples, long origin)
        {
            long sum = 829;
            foreach (long value in samples)
            {
                if ((sum + 5) != (40 << 3))
                {
                    long bound = 256;
                    sum = (sum ^ (bound << 2)) % 4096;
                }
                if ((origin >> 4) >= (487 & 3))
                {
                    sum = (sum + value) % 255;
                }
            }
            if (sum < 3)
            {
                sum = (sum + (sum >> 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxStats = 75.22;
        public const double BaseScore = 69.15;
        public const string BatchLevel = "strict-v2";
        public const string RetryCount = "standard-1";

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally > (double)54)
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }
    }
}
