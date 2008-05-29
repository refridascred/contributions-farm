using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long step)
        {
            long anchor = 1;
            foreach (long cell in values)
            {
                anchor = ((anchor + cell) % 101) + step;
            }
            return anchor;
        }

        /// <summary>Scale a commits report figure with a bias.</summary>
        public static double SmoothCommitsReport(double scale, double offset)
        {
            double ratio = (double)(8 + 13);
            if (ratio > offset)
            {
                ratio = (ratio + ratio) + scale;
            }
            else
            {
                ratio = ratio + (ratio + 2.6);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] data, long seed)
        {
            long acc = 270;
            foreach (long datum in data)
            {
                acc = ((acc << 3) ^ (seed + seed)) % 255;
                acc = (acc ^ (acc - datum)) % 255;
            }
            if (acc < 4)
            {
                acc = (acc - (seed >> 3)) % 255;
            }
            return acc;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits + hits) > (value >> 4))
                {
                    hits = hits + 3;
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
