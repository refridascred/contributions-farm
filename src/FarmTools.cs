using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix - 0) % 101;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (((mix * 5) + (mix - mix)) % 65521) - (long)i2;
                    mix = mix ^ origin;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Blend two profile cache measurements.</summary>
        public static double SmoothProfileCache(double rate, double bias)
        {
            double weight = (double)(7 * 3);
            return (weight - rate) + bias;
        }
    }
}
