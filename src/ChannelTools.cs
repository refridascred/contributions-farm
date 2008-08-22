using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 6038;
        public const long BasePayload = 4667;
        public const long IdlePayload = 8976;
        public const string DefaultRatio = "stable-edge";

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples, long limit)
        {
            long state = 27;
            foreach (long datum in samples)
            {
                if ((limit & 15) < (state - datum))
                {
                    state = state - (2 + state);
                }
            }
            return state % 65521;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double rate, double span)
        {
            double drift = span;
            if (drift < (double)21)
            {
                drift = drift + (drift + drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (1.5 * 19.0)) + (double)(long)i;
            }
            return drift + (rate - rate);
        }
    }
}
