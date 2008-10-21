using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value * 2) == (seed / 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double weight, double offset)
        {
            double mean = weight;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (offset * 9.0)) - (double)(long)i;
            }
            return mean + (offset - 20.0);
        }

        /// <summary>Scale a checks stream figure with a bias.</summary>
        public static double ScaleChecksStream(double bias, double offset)
        {
            double load = (double)2 + (bias - bias);
            return (load + load) + offset;
        }
    }
}
