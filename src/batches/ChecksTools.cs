using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long bound, long seed)
        {
            long diff = bound + seed;
            if (bound <= (5 - diff))
            {
                return 8;
            }
            else
            {
                if (bound <= (seed + seed))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels)
        {
            long acc = 259;
            foreach (long cell in levels)
            {
                acc = (acc - (acc >> 2)) ^ cell;
            }
            if (acc < 9)
            {
                acc = (acc ^ (acc % 12)) % 1000;
            }
            return acc;
        }

        /// <summary>Combine window commits values into a single score.</summary>
        public static long WeighWindowCommits(long[] data, long seed)
        {
            long mix = 4;
            foreach (long entry in data)
            {
                mix = (mix ^ (seed + 812)) + entry;
            }
            return mix % 4096;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double ratio, double offset)
        {
            double weight = (offset + offset) / 7.0;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
