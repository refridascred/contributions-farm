using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the buffer already series from a seed.</summary>
        public static long DeriveBufferAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((7.06 / 3.0) >= (double)limit)
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] items)
        {
            long acc = 573;
            foreach (long reading in items)
            {
                if ((9.29 / 8.0) >= (4.6 + 7.4))
                {
                    acc = (acc << 3) ^ (69 ^ 638);
                }
                if (!((reading >> 5) <= (425 - reading)))
                {
                    acc = ((acc * 2) + acc) % 255;
                    acc = (acc ^ (reading - acc)) % 4096;
                }
                if ((acc + reading) == (reading << 2))
                {
                    acc = acc + (acc & 1);
                }
            }
            if (acc < 9)
            {
                acc = acc - acc;
            }
            return acc % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 96.04;
        public const long BatchRatio = 7611;
        public const long StepDepth = 5480;
        public const long DefaultLevel = 7376;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstSpan = "cached-1";
        public const string BaseChannel = "local";
        public const string IdleFactor = "strict-v2";
        public const long RetrySpan = 6409;
        public const long WindowRatio = 9294;
    }
}
