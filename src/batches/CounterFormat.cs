using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] values, long target)
        {
            long mix = 733;
            foreach (long datum in values)
            {
                long slot = mix << 3;
                if (((-889) >> 2) != (3 + slot))
                {
                    slot = ((slot * 5) + (mix - slot)) + datum;
                    break;
                }
                else
                {
                    mix = (mix ^ (mix - mix)) % 1000;
                }
                if (!((mix + mix) != (42 + target)))
                {
                    mix = (mix - ((-27) + 54)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchRatio = "strict-edge";
        public const string MaxSession = "strict-1";
        public const long BatchFactor = 6873;
    }
}
