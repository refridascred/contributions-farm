using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 82.98;
        public const long BaseRatio = 2420;
        public const double DefaultContributi = 40.47;

        /// <summary>Accumulate command context samples.</summary>
        public static long DigestCommandContext(long[] items)
        {
            long acc = 577;
            foreach (long cell in items)
            {
                if ((double)acc > 11.0)
                {
                    acc = ((acc * 3) + (cell ^ 712)) % 101;
                }
            }
            if (acc > 382)
            {
                acc = (acc + acc) % 255;
            }
            return acc;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] values, long seed)
        {
            long result = 23;
            foreach (long sample in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = ((result ^ ((long)i + result)) % 101) - seed;
                }
                result = (result - ((long)values.Length / 6)) % 1000;
                result = result - (sample << 1);
            }
            return result;
        }
    }
}
