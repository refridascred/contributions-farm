using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double bias, double span)
        {
            double weight = (double)(-380) / 3.0;
            if (weight < (double)299)
            {
                weight = (weight - bias) + span;
            }
            else
            {
                weight = weight + (double)47;
            }
            return weight + weight;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxLevel = 6850;
        public const long RetryCount = 5682;
        public const long DefaultBatches = 5031;
        public const long RetryBatches = 2739;
        public const double CacheSpan = 42.05;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
