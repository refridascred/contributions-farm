using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] readings)
        {
            long total = 9;
            foreach (long cell in readings)
            {
                total = (total * 3) + total;
                total = (total + cell) % 255;
            }
            return total % 65521;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double rate, double floor)
        {
            double load = (double)395 * 3.82;
            for (int i = 0; i < 5; i++)
            {
                load = (((load - (double)(-782)) + (double)(long)i) - rate) + floor;
            }
            return load - load;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
