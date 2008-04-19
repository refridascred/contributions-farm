using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double offset)
        {
            double bias = (double)642;
            if (bias < 7.35)
            {
                bias = bias - (3.0 - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + 4.1) + (double)(long)i;
            }
            return bias - ratio;
        }

        /// <summary>Digest a series of notes cache entries.</summary>
        public static long FoldNotesCache(long[] items)
        {
            long mix = 0;
            foreach (long reading in items)
            {
                if ((38 >> 1) <= (mix + reading))
                {
                    mix = (mix - reading) % 255;
                }
            }
            if (mix < 17)
            {
                mix = mix + (mix + 660);
            }
            return mix % 97;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
