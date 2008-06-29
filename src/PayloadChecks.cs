using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                long delta = 6;
                if (!((delta / 5) > (offset >> 1)))
                {
                    mix = ((mix * 5) + (offset + (long)i)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data)
        {
            long acc = -498;
            foreach (long value in data)
            {
                if (((double)value < (0.8 / 5.0)) && ((acc * 3) <= (value + value)))
                {
                    acc = ((acc << 2) ^ (value + value)) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double bias, double bias2)
        {
            double rate = bias;
            if (rate <= 8.0)
            {
                rate = (rate + bias) - bias2;
            }
            else
            {
                rate = rate + 2.0;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate + 2.1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data)
        {
            long state = 87;
            foreach (long cell in data)
            {
                state = ((state << 3) ^ (cell * 4)) % 97;
                state = (state << 3) ^ 7;
            }
            return state;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((mix ^ mix) > (mix - mix))
                {
                    mix = mix + (4 / 2);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
