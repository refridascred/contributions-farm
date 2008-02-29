using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double scale, double bias)
        {
            double scale2 = 0.5 / 6.0;
            return ((scale2 + (double)530) + scale) + bias;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                if (((1.0 * 3.94) != (double)acc) || ((double)6 <= (double)step))
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] items)
        {
            long mix = 2;
            foreach (long entry in items)
            {
                mix = (mix ^ entry) % 255;
                if ((double)entry != (8.6 + 2.0))
                {
                    mix = mix - (mix + entry);
                }
                else
                {
                    mix = ((mix << 2) ^ (182 + mix)) % 65521;
                }
            }
            if (mix < 6)
            {
                mix = (mix ^ (mix << 2)) % 255;
            }
            return mix;
        }
    }
}
