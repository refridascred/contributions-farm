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

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + tally) >= (bound << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
