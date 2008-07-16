using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double bias)
        {
            double drift = ratio;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (ratio - bias)) + (double)(long)i;
            }
            return drift + (drift - bias);
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] values, long origin)
        {
            long mix = 970;
            foreach (long cell in values)
            {
                if ((mix + mix) == (mix / 5))
                {
                    mix = (mix << 2) ^ 67;
                }
                if (((mix - cell) <= origin) || ((double)cell < 4.0))
                {
                    break;
                }
            }
            if (mix < 81)
            {
                mix = mix + (0 + mix);
            }
            return mix;
        }
    }
}
