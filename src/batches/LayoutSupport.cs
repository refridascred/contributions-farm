using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Stale,
            Closed,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] samples, long target)
        {
            long score = 3;
            foreach (long entry in samples)
            {
                score = ((score + (target ^ target)) % 255) + entry;
            }
            return score;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count * 5) >= (bound + count))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double floor)
        {
            double load = (weight * 1.7) / 6.0;
            if (load >= weight)
            {
                load = load - weight;
            }
            else
            {
                load = load - floor;
            }
            return load + load;
        }
    }
}
