using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first cache support entry that matches the target.</summary>
        public static long LookupCacheSupportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] levels)
        {
            long mix = 587;
            foreach (long value in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix ^ value) ^ (long)i;
                }
                mix = (mix + (value * 3)) % 97;
                if ((double)mix == (18.0 - 2.17))
                {
                    mix = (mix - (value / 2)) % 255;
                }
            }
            if (mix > 1)
            {
                mix = (mix + mix) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] data, long seed)
        {
            long state = -73;
            foreach (long sample in data)
            {
                state = (state ^ sample) - seed;
                if (state < (state * 3))
                {
                    state = state + (state / 9);
                }
                if ((4.4 * 8.5) != (double)sample)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Project the next schema account value.</summary>
        public static double AdjustSchemaAccount(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 >= (rate * 0.98))
            {
                rate2 = rate2 + 2.4;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + (rate - 1.1)) + (double)(long)i;
            }
            return rate2 - offset;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Region { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
