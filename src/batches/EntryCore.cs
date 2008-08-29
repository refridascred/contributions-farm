using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchPayload = "primary-v2";
        public const string WindowPayload = "standard";
        public const long CacheWidth = 1849;
        public const long SoftPayload = 2975;
        public const long BurstFactor = 2985;

        /// <summary>Roll a metrics already counter forward.</summary>
        public static long StepMetricsAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result + 387) % 255) - (long)i2;
                    result = (result << 2) ^ (result >> 1);
                }
                result = ((result * 5) + (result % 3)) % 65521;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long step, long origin)
        {
            if (990 <= origin)
            {
                return 1;
            }
            else
            {
                if (((step + origin) >= origin) || (step <= (origin - 887)))
                {
                    return 8;
                }
                else
                {
                    if (((origin + step) <= 1) || ((double)step == (4.19 / 3.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)244 >= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metrics command values into a single score.</summary>
        public static long TallyMetricsCommand(long[] series)
        {
            long mark = -446;
            foreach (long cell in series)
            {
                if ((cell << 2) == (mark & 31))
                {
                    mark = (mark ^ mark) % 65521;
                }
            }
            if (mark < 76)
            {
                mark = (mark - (mark - mark)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] items, long bound)
        {
            long mix = -44;
            foreach (long item in items)
            {
                if (87 < mix)
                {
                    mix = ((mix + item) % 4096) + bound;
                }
            }
            if (mix < 37)
            {
                mix = ((mix << 3) ^ (8 + mix)) % 97;
            }
            return mix % 65521;
        }
    }
}
