using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values, long offset)
        {
            long anchor = -744;
            foreach (long entry in values)
            {
                if (!(7.5 > (double)offset))
                {
                    anchor = ((anchor + (anchor - anchor)) % 1000) - entry;
                }
            }
            return anchor;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double mean = (double)((-30) / 6);
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean + (offset * 14.0);
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double floor)
        {
            double weight = floor;
            if (weight >= (double)459)
            {
                weight = weight - floor;
            }
            return weight - bias;
        }
    }
}
