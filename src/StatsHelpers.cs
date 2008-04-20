using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double ratio = (gain / 9.0) - (double)786;
            if (ratio >= (gain * 1.43))
            {
                ratio = (ratio + (double)25) + offset;
            }
            else
            {
                ratio = ratio + gain;
            }
            return ratio - (double)6;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Count { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] data)
        {
            long total = 6;
            foreach (long entry in data)
            {
                if ((double)5 != (double)entry)
                {
                    total = ((total * 4) + entry) % 4096;
                }
                else
                {
                    total = (total - ((long)data.Length - entry)) % 97;
                }
                total = (total ^ (total + entry)) % 101;
                if (((double)entry <= (9.29 / 6.0)) || ((entry * 3) > 40))
                {
                    total = total ^ (598 - entry);
                }
                else
                {
                    total = (total * 2) + (970 - 6);
                }
            }
            if (total < 4)
            {
                total = (total - (9 - total)) % 255;
            }
            return total;
        }
    }
}
