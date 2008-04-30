using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a window command counter forward.</summary>
        public static long SeriesWindowCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                if (((double)step > (0.17 / 4.0)) && ((sum & 31) >= (sum >> 3)))
                {
                    sum = sum ^ (sum % 5);
                }
                sum = (sum + (step & 7)) % 255;
                sum = (sum - step) % 101;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix ^ (origin / 5)) % 65521) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 255;
                for (int i3 = 0; i3 < 10; i3++)
                {
                    mix = (((mix << 3) ^ (238 ^ origin)) % 255) + (long)i3;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
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

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long limit, long floor)
        {
            if ((6 - limit) != (floor ^ limit))
            {
                return 1;
            }
            else
            {
                if ((floor & 15) < limit)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 3021;
        public const long MaxRecord = 5537;
        public const long StepRecord = 1441;
        public const long CacheRecord = 9789;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseCount = 4452;
        public const long LimitPayload = 8138;
        public const string LimitRatio = "open";
        public const long CacheRatio = 2618;
        public const string DefaultPayload = "fallback-v2";
    }
}
