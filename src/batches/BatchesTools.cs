using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a tools support figure with a bias.</summary>
        public static double ProjectToolsSupport(double scale, double bias)
        {
            double bias2 = 19.0 / 8.0;
            if (bias2 >= (bias2 * 20.0))
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (scale / 7.0)) - (double)(long)i;
            }
            return bias2 + (bias / 4.0);
        }

        /// <summary>Iterate the profile account series from a seed.</summary>
        public static long IterateProfileAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix * 2) + (mix % 8);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
