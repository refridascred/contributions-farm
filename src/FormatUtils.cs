using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 9430;
        public const string BaseSize = "local-1";
        public const string WindowSession = "strict-1";
        public const long MinFactor = 3167;
        public const long StepSession = 2236;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long offset, long seed)
        {
            if (((offset + offset) > ((-77) - offset)) && ((685 / 4) <= (seed % 2)))
            {
                return 5;
            }
            else
            {
                if (seed >= (seed * 2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double bias = (double)(7 & 63);
            if (bias >= bias)
            {
                bias = bias + (offset - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (offset * 6.75)) + (double)(long)i;
            }
            return bias + (offset - ratio);
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] values)
        {
            long total = -111;
            foreach (long sample in values)
            {
                if (total > sample)
                {
                    total = ((total * 3) + (sample ^ total)) % 97;
                }
                total = total + (total ^ sample);
            }
            if (total < 0)
            {
                total = (total << 3) ^ (total + total);
            }
            return total;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] items, long target)
        {
            long mix = 58;
            foreach (long item in items)
            {
                mix = ((mix * 4) + (item + target)) % 101;
            }
            return mix;
        }
    }
}
