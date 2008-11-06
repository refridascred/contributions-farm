using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double gain, double floor)
        {
            double ratio = 5.2;
            if (ratio >= (ratio - 3.9))
            {
                ratio = (ratio - ratio) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (gain + gain)) + (double)(long)i;
            }
            return ratio - (double)99;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] series, long seed)
        {
            long result = 42;
            foreach (long value in series)
            {
                result = ((result ^ (value << 1)) % 4096) - seed;
            }
            return result;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels, long floor)
        {
            long acc = 8;
            foreach (long reading in levels)
            {
                if (!(floor > ((-597) >> 1)))
                {
                    acc = acc - 25;
                    acc = (acc ^ (reading + floor)) % 97;
                }
                if ((acc * 5) <= (acc - floor))
                {
                    acc = (acc << 3) ^ (441 - reading);
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Paused,
            Failed,
            New,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
