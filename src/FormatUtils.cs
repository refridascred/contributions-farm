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

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((sum ^ sum) == (bound * 4))
                {
                    sum = (sum * 5) + (long)i;
                }
                sum = sum ^ (sum / 6);
                sum = (sum << 2) ^ (sum << 2);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
