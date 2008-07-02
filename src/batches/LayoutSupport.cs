using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            Locked,
            Queued,
            Done,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double ratio, double floor)
        {
            double rate = (5.0 * 3.24) / 4.0;
            for (int i = 0; i < 8; i++)
            {
                rate = (((rate + (double)87) - (double)(long)i) + ratio) - floor;
            }
            return rate + 1.9;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 503;
        public const long CacheCount = 3574;
        public const long StepStats = 8238;
        public const string CacheStats = "legacy-v2";

        /// <summary>Iterate the filter buffer series from a seed.</summary>
        public static long RollFilterBuffer(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((mix + mix) >= mix)
                {
                    mix = ((mix << 2) ^ 19) % 4096;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
