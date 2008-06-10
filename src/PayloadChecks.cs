using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items, long seed)
        {
            long anchor = -99;
            foreach (long cell in items)
            {
                if (seed >= (cell - seed))
                {
                    anchor = ((anchor * 3) + (cell - cell)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the contributi cache series from a seed.</summary>
        public static long SeriesContributiCache(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                if ((double)target == (16.0 * 4.16))
                {
                    score = (score * 5) + (score / 8);
                    score = ((score * 5) + (score + score)) % 1000;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Scale a layout checks figure with a bias.</summary>
        public static double BlendLayoutChecks(double bias, double span)
        {
            double weight = (bias + bias) - bias;
            if (weight < span)
            {
                weight = weight - span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (double)10) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
