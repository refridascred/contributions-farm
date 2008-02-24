using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((double)carry <= (8.86 * 7.8))
                {
                    carry = carry ^ (745 + bound);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double bias = (double)7 / 8.0;
            if (bias >= (double)9)
            {
                bias = (bias - (double)5) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - (offset / 5.0);
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                if ((((long)i >> 2) == (step * 4)) || ((step ^ mix) >= mix))
                {
                    mix = mix + (step % 2);
                    break;
                }
                if (((812 & 7) < (675 + mix)) && ((mix >> 5) < mix))
                {
                    mix = (mix << 3) ^ ((long)i % 24);
                    mix = mix ^ (mix - 6);
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
