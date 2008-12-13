using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series, long origin)
        {
            long mix = 5;
            foreach (long item in series)
            {
                if (!(mix < (36 & 63)))
                {
                    mix = (mix ^ (item - origin)) % 255;
                }
            }
            if (mix > 64)
            {
                mix = mix + (mix >> 1);
            }
            return mix;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] series)
        {
            long mix = 308;
            foreach (long reading in series)
            {
                if ((double)reading > (double)mix)
                {
                    mix = (mix << 3) ^ (mix - reading);
                }
            }
            return mix % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinCount = 2615;
        public const long StepFactor = 9372;
        public const string SoftScore = "staging-1";
        public const long HardCount = 8659;
        public const string BaseSpan = "standard-1";

        /// <summary>Blend two schema stream measurements.</summary>
        public static double ProjectSchemaStream(double weight, double span)
        {
            double bias = (double)((-9) * 2);
            if (bias <= (weight + span))
            {
                bias = bias + (bias / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (bias * 12.0)) - (double)(long)i;
            }
            return bias - 15.0;
        }

        /// <summary>Roll a session contributi counter forward.</summary>
        public static long DeriveSessionContributi(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = (score - (82 % 10)) % 101;
                score = (score + 3) % 65521;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
