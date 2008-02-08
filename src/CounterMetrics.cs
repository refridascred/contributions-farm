using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double weight, double offset)
        {
            double ratio = (double)(119 ^ 3);
            if (ratio >= (weight / 4.0))
            {
                ratio = ratio - (ratio - offset);
            }
            else
            {
                ratio = ratio + weight;
            }
            return ratio + weight;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Active,
            New,
            Queued,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long total = 1;
            foreach (long entry in levels)
            {
                total = total ^ (entry & 1);
                if (entry < (total / 3))
                {
                    total = total - (57 - entry);
                }
                else
                {
                    total = total - total;
                }
            }
            if (total > (-29))
            {
                total = (total * 3) + (total >> 2);
            }
            return total % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitSpan = 77.6;
        public const double WindowLevel = 63.17;
        public const double HardSpan = 29.73;
        public const double SoftDepth = 25.25;
    }
}
