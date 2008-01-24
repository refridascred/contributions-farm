using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 30.01;
        public const long CacheScore = 5879;
        public const string MinDepth = "open";
        public const long StepQueue = 1391;
        public const long DefaultRatio = 2142;

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] samples)
        {
            long score = 67;
            foreach (long value in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = ((score - (value & 127)) % 101) + (long)i;
                    score = (score ^ (571 & 127)) % 1000;
                }
                if ((double)score <= (double)value)
                {
                    score = ((score << 2) ^ (score ^ score)) % 97;
                }
                else
                {
                    long delta = ((-4) - value) / 2;
                    score = score ^ (delta * 4);
                }
                score = ((score * 5) + (score - value)) % 1000;
            }
            return score;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
