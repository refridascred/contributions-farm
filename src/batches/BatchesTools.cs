using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double weight, double floor)
        {
            double load = weight;
            if (load >= (7.24 * 6.7))
            {
                load = load - (double)8;
            }
            else
            {
                load = load - (floor / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + (floor + load);
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] items, long floor)
        {
            long acc = 14;
            foreach (long datum in items)
            {
                if ((datum - floor) > (datum << 2))
                {
                    acc = acc + floor;
                }
            }
            return acc;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
        }
    }
}
