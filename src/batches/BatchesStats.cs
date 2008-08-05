using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((1.8 * 13.0) > (double)hits) && ((hits * 4) >= 9))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                total = (total + (total + 64)) % 255;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > (weight / 2.0))
            {
                ratio = (ratio - (ratio * 5.69)) + offset;
            }
            return ratio + ratio;
        }
    }
}
