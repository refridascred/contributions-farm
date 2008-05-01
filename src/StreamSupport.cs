using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the contributi report series from a seed.</summary>
        public static long SeriesContributiReport(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 2) + (total * 2)) % 65521;
                if ((step >= total) && (((long)i * 2) < (total ^ 288)))
                {
                    total = ((total * 2) + (step + step)) % 255;
                }
                else
                {
                    total = (total + step) % 1000;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double ratio, double span)
        {
            double weight = span;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + (double)91;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 3164;
        public const double BatchTimeout = 58.83;
        public const double HardStats = 91.45;
        public const string DefaultDepth = "open-v2";
        public const long DefaultInterval = 6903;
    }
}
