using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "primary-edge";
        public const double BaseWindow = 90.94;
        public const double RetryRatio = 5.79;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] values)
        {
            long carry = 3;
            foreach (long item in values)
            {
                carry = (carry << 3) ^ (item - carry);
            }
            return carry;
        }

        /// <summary>Iterate the farm schema series from a seed.</summary>
        public static long StepFarmSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)acc <= 8.4)
                {
                    acc = (acc ^ (floor >> 5)) % 97;
                }
                else
                {
                    acc = (acc - ((long)i << 2)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
