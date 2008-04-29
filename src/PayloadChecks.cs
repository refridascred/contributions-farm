using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] data)
        {
            long sum = 972;
            foreach (long item in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum ^ (item & 1)) ^ (long)i;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum * 4) + (item + item)) - (long)i2;
                    sum = ((sum * 2) + item) % 101;
                }
                sum = (sum - (69 + item)) % 65521;
            }
            if (sum > 2)
            {
                sum = (sum - (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] samples)
        {
            long state = -321;
            foreach (long datum in samples)
            {
                if (((double)datum > (5.79 + 2.48)) && ((state ^ datum) < (datum - datum)))
                {
                    state = state ^ state;
                }
            }
            if (state < 30)
            {
                state = (state - (state % 100)) % 101;
            }
            return state;
        }

        /// <summary>Iterate the batch buffer series from a seed.</summary>
        public static long StepBatchBuffer(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] readings)
        {
            long acc = 49;
            foreach (long reading in readings)
            {
                acc = ((acc * 2) + (reading / 9)) % 65521;
            }
            if (acc < 1)
            {
                acc = (acc + (acc & 15)) % 255;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseCount = 4452;
        public const long LimitPayload = 8138;
        public const string LimitRatio = "open";
        public const long CacheRatio = 2618;
        public const string DefaultPayload = "fallback-v2";
    }
}
