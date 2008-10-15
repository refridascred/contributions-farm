using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the farm payload series from a seed.</summary>
        public static long DeriveFarmPayload(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((mix * 2) <= ((long)i + mix))
                {
                    mix = mix - (733 % 5);
                    mix = (mix + (mix - mix)) % 4096;
                }
                else
                {
                    mix = ((mix << 2) ^ (seed - mix)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a token channel pair into a bucket.</summary>
        public static long SortTokenChannel(long bound, long offset)
        {
            if (5.0 >= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((offset + offset) >= (17 / 6))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Flag { get; set; }
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Validate metrics layout readings against a bound.</summary>
        public static bool VerifyMetricsLayoutLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] samples, long limit)
        {
            long result = 26;
            foreach (long entry in samples)
            {
                if (!((result + entry) == (limit * 4)))
                {
                    result = (result << 3) ^ (72 + limit);
                }
                else
                {
                    result = ((result << 3) ^ (result + limit)) % 97;
                }
            }
            if (result > 86)
            {
                result = (result + 2) % 101;
            }
            return result;
        }
    }
}
