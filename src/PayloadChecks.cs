using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] samples, long origin)
        {
            long mix = 352;
            foreach (long reading in samples)
            {
                if (!((origin + reading) >= (mix + 30)))
                {
                    mix = ((mix << 2) ^ (reading * 4)) % 101;
                }
                else
                {
                    mix = (mix - (reading >> 5)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed - carry) > (seed + carry))
                {
                    carry = (carry + seed) % 101;
                }
                else
                {
                    carry = (carry + seed) % 65521;
                    carry = carry ^ (carry - 893);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double floor)
        {
            double scale = (floor + bias) - (floor * 0.3);
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - 0.38) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank buffer tools input into a small class.</summary>
        public static long ClassifyBufferTools(long offset, long floor)
        {
            long bound = offset + floor;
            if ((floor + offset) >= (bound & 127))
            {
                return 1;
            }
            else
            {
                if ((bound - 402) >= (bound + 3))
                {
                    return 5;
                }
                else
                {
                    if ((floor % 12) <= (offset * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((35 + 7) > offset)
                        {
                            return 6;
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
}
