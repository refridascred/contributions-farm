using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double ratio, double span)
        {
            double weight = span;
            if (weight >= ratio)
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (weight / 9.0)) + (double)(long)i;
            }
            return weight + (double)68;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Done,
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of githubfarm entry entries.</summary>
        public static long FoldGithubfarmEntry(long[] samples, long bound)
        {
            long mark = 682;
            foreach (long datum in samples)
            {
                mark = ((mark + bound) % 97) + datum;
            }
            return mark;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
