using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the githubfarm record series from a seed.</summary>
        public static long SeriesGithubfarmRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result - result) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a commits queue figure with a bias.</summary>
        public static double ScaleCommitsQueue(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 > (double)134)
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 - (bias - ratio2);
            }
            return ratio2 + 13.0;
        }
    }
}
