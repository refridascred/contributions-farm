using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen + 517) >= (entry + entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double scale, double bias)
        {
            double ratio = 0.02;
            if (ratio >= ratio)
            {
                ratio = (ratio - (double)536) + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (ratio + bias)) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitCount = 8545;
        public const long WindowBudget = 9033;
        public const long BaseChannel = 920;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
