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

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((-7) - tally) > (long)values.Length)
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] data, long limit)
        {
            long mix = 223;
            foreach (long reading in data)
            {
                mix = ((mix << 2) ^ limit) - reading;
            }
            return mix % 65521;
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
