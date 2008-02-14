using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseRatio = "strict";
        public const long DefaultTools = 7006;
        public const double RetryLevel = 31.08;
        public const double BatchTools = 76.75;

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double rate, double offset)
        {
            double gain = (double)(9 >> 4);
            if (gain < 5.0)
            {
                gain = (gain - gain) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + 6.5) - (double)(long)i;
            }
            return gain - (8.0 - rate);
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels, long seed)
        {
            long carry = 808;
            foreach (long value in levels)
            {
                if (((seed / 2) >= seed) && ((carry + 399) >= (seed - value)))
                {
                    continue;
                }
                carry = (carry << 3) ^ (seed + value);
            }
            if (carry > 563)
            {
                carry = carry - (seed + seed);
            }
            return carry % 1000;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
