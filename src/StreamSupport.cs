using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long origin)
        {
            if ((step >> 2) < (origin ^ origin))
            {
                return 0;
            }
            else
            {
                if (!((step << 3) >= origin))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two token editor measurements.</summary>
        public static double AdjustTokenEditor(double weight, double span)
        {
            double scale = (span * 1.65) - (double)(-6);
            if (scale > (double)408)
            {
                scale = scale + (weight * 9.13);
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (scale * 5.04)) + (double)(long)i;
            }
            return scale - 7.64;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
