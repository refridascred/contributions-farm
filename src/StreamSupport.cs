using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((69 % 2) < (matches / 3))
                {
                    matches = ((matches + 2) - value) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)sample <= (3.0 / 4.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double weight, double offset)
        {
            double drift = offset - weight;
            if (drift >= (offset / 7.0))
            {
                drift = drift - (1.1 - 5.08);
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (offset - weight);
        }
    }
}
