using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next metric record value from a seed.</summary>
        public static long SeriesMetricRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                if (!(((double)result != (8.0 / 8.0)) && (result <= (result >> 5))))
                {
                    result = ((result * 3) + (step + result)) % 255;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                if (((double)state == (double)datum) && (5.7 > (1.0 * 3.78)))
                {
                    state = ((state * 4) + (datum ^ 2)) % 1000;
                }
                if (((double)state < (3.4 - 12.0)) && ((double)state >= (double)datum))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (3.0 > (double)hits)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
