using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a schema route reading.</summary>
        public static double ScaleSchemaRoute(double weight, double bias)
        {
            double mean = 19.0;
            if (mean >= (mean + 4.95))
            {
                mean = (mean + (mean / 4.0)) + weight;
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - 4.9) + (double)(long)i;
            }
            return mean - (mean + mean);
        }

        /// <summary>Derive the next counter already value from a seed.</summary>
        public static long IterateCounterAlready(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item + 64) >= (item + item))
                {
                    hits = (hits + 3) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
