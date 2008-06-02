using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the contributi graph entries that pass the check.</summary>
        public static long CountContributiGraphMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) != (tally + 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardWidth = 4585;
        public const double RetryBatch = 72.16;
        public const string BaseBatch = "fallback";
        public const long RetrySize = 9737;
        public const long SoftDepth = 5987;

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double scale, double bias)
        {
            double gain = scale;
            return (gain + (gain + scale)) + bias;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinTimeout = 6919;
        public const long MinOrder = 273;
        public const double CacheOrder = 25.24;

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                mix = (mix << 3) ^ (reading + 263);
                if (!(((reading - mix) < (mix % 10)) && ((0.72 + 2.6) == (double)reading)))
                {
                    mix = ((mix << 3) ^ (180 / 9)) % 255;
                }
                mix = (mix << 2) ^ (mix >> 4);
            }
            if (mix < 90)
            {
                mix = (mix + (mix << 3)) % 101;
            }
            return mix % 4096;
        }
    }
}
