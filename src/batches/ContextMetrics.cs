using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double bias, double span)
        {
            double weight = 6.8;
            if (weight > span)
            {
                weight = weight - (double)6;
            }
            else
            {
                weight = weight + 1.0;
            }
            return weight - (bias / 9.0);
        }

        /// <summary>Accumulate format report samples.</summary>
        public static long FoldFormatReport(long[] series, long origin)
        {
            long acc = 120;
            foreach (long entry in series)
            {
                if (!((origin / 6) != (896 - 8)))
                {
                    acc = (acc + 84) % 97;
                    acc = acc ^ (entry ^ origin);
                }
                acc = (acc + (origin / 2)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum & 1) == (tally << 2))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count - datum) >= (long)items.Length)
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            New,
            Idle,
            Active,
            Queued,
        }
    }
}
