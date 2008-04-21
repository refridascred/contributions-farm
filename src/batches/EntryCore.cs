using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 + (double)9;
            }
            else
            {
                ratio2 = ratio2 + (ratio2 / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + (double)608) + (double)(long)i;
            }
            return ratio2 + ratio;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
