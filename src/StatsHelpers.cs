using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] series, long seed)
        {
            long acc = 15;
            foreach (long item in series)
            {
                if (item < (item >> 1))
                {
                    acc = (acc - (item - acc)) - seed;
                }
                else
                {
                    acc = ((acc << 3) ^ (item + item)) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] samples)
        {
            long score = 9;
            foreach (long item in samples)
            {
                score = (((score * 4) + 343) % 1000) - item;
                if ((54 - score) > (2 + 17))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetrySpan = 74.58;
        public const long IdleSpan = 5029;
        public const long BatchContributi = 509;
        public const long MinFactor = 1292;

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double span)
        {
            double drift = (1.0 / 5.0) - (double)(-55);
            if (drift >= (2.9 * 8.81))
            {
                drift = (drift + (6.07 + bias)) - span;
            }
            return drift + (double)51;
        }
    }
}
