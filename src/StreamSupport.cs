using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next support stream value from a seed.</summary>
        public static long SeriesSupportStream(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (mix + (long)i)) % 255;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (((mix * 5) + origin) % 101) ^ (long)i2;
                    mix = ((mix * 3) + origin) % 255;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count + count) > (target >> 4)) || ((count * 5) <= (item + target)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 86.56;
        public const double SoftMetric = 82.36;
        public const long HardDepth = 5299;
    }
}
