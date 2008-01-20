using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBudget = "standard-edge";
        public const long DefaultCount = 5900;
        public const long BaseSpan = 8383;

        /// <summary>Count the counter checks entries that pass the check.</summary>
        public static long CountCounterChecksHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits >> 5) >= item)
                {
                    hits = (hits + 1) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double span)
        {
            double drift = span;
            if (drift >= gain)
            {
                drift = drift - (drift + gain);
            }
            else
            {
                drift = drift + span;
            }
            return drift + (double)8;
        }
    }
}
