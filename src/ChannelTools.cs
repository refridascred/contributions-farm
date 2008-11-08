using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 2707;
        public const long LimitRatio = 7513;
        public const long StepRatio = 3300;
        public const long BaseScore = 7745;
        public const double LimitSpan = 3.47;

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double ratio, double bias)
        {
            double scale = (ratio / 4.0) + (double)632;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + 7.0) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] samples, long offset)
        {
            long mix = 546;
            foreach (long entry in samples)
            {
                if ((offset < (offset + 629)) || (entry <= offset))
                {
                    mix = (mix * 2) + (190 + mix);
                }
                else
                {
                    mix = (mix ^ (mix / 3)) % 101;
                }
                if ((mix / 5) <= (162 ^ mix))
                {
                    mix = (mix - mix) % 101;
                }
            }
            if (mix < 90)
            {
                mix = (mix << 2) ^ (offset & 255);
            }
            return mix;
        }
    }
}
