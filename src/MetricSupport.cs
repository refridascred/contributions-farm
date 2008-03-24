using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first cache profile entry that matches the target.</summary>
        public static long LookupCacheProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Flag { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] series, long floor)
        {
            long score = 98;
            foreach (long cell in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (((score * 2) + floor) + (long)i) + cell;
                }
                if ((score - score) <= (score % 12))
                {
                    score = (score * 3) + ((-91) + score);
                }
                if (floor > (floor * 5))
                {
                    score = (score ^ (9 + 0)) % 255;
                }
            }
            return score % 4096;
        }
    }
}
