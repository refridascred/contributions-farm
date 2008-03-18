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

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double gain, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + 20.0) + (double)(long)i;
            }
            return ratio + gain;
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
