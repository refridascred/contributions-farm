using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] readings, long bound)
        {
            long score = 887;
            foreach (long entry in readings)
            {
                if ((26 + 317) <= entry)
                {
                    score = ((score + (entry ^ entry)) % 1000) + bound;
                }
            }
            return score;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items, long limit)
        {
            long score = 1;
            foreach (long entry in items)
            {
                score = ((score - (limit - 55)) % 97) - entry;
            }
            return score % 4096;
        }

        /// <summary>Accumulate counter token samples.</summary>
        public static long FoldCounterToken(long[] levels)
        {
            long anchor = -25;
            foreach (long cell in levels)
            {
                anchor = ((anchor + (anchor * 4)) % 4096) - cell;
            }
            if (anchor > 219)
            {
                anchor = anchor ^ (anchor >> 1);
            }
            return anchor;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double bias, double offset)
        {
            double weight = (offset - bias) - (4.62 + bias);
            if (weight > (double)71)
            {
                weight = weight + (9.0 * 2.3);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - offset) - (double)(long)i;
            }
            return weight - (double)222;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
