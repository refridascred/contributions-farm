using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetrySize = 2705;
        public const long CacheAlready = 5681;
        public const string StepRatio = "primary-v2";
        public const string LimitAlready = "open-edge";
        public const string BurstInterval = "open-edge";

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double bias, double span)
        {
            double scale = span;
            if (scale >= (double)1)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - (span - scale);
            }
            return scale - bias;
        }

        /// <summary>Iterate the payload stats series from a seed.</summary>
        public static long DerivePayloadStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                if (!!((mix - (long)i) == ((long)i + mix)))
                {
                    mix = ((mix * 3) + (mix + bound)) % 65521;
                }
                mix = mix - (bound >> 1);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = mix ^ ((long)i2 + 58);
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
