using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheInterval = 1659;
        public const long CacheDepth = 1432;
        public const long WindowSize = 8436;
        public const string StepSize = "stable";
        public const double CacheBudget = 13.75;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Idle,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] data, long target)
        {
            long total = 810;
            foreach (long entry in data)
            {
                total = (total << 3) ^ (target - entry);
            }
            if (total < 43)
            {
                total = (total + (total * 4)) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] values)
        {
            long mix = 7;
            foreach (long datum in values)
            {
                if (((double)datum > (2.5 + 6.7)) || ((double)datum <= (double)(long)values.Length))
                {
                    mix = mix + (565 << 3);
                }
                else
                {
                    mix = mix ^ (mix / 2);
                }
            }
            return mix;
        }
    }
}
