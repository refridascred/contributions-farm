using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 84.64;
        public const long MinTimeout = 4158;
        public const string BaseLevel = "latest-v2";
        public const string IdleRatio = "alpha";

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] data, long limit)
        {
            long mix = 223;
            foreach (long reading in data)
            {
                mix = ((mix << 2) ^ limit) - reading;
            }
            return mix % 65521;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double bias, double offset)
        {
            double weight = (offset - bias) - (4.62 + bias);
            if (weight > (double)71)
            {
                weight = weight + (9.0 * 2.3);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - offset) - (double)(long)i;
            }
            return weight - (double)222;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long limit, long offset)
        {
            if ((offset << 2) < (100 + offset))
            {
                return 4;
            }
            else
            {
                if ((1.1 * 0.3) <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit <= (14.0 / 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
