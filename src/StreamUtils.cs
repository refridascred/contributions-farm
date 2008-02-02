using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Pending,
            Synced,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] samples)
        {
            long result = 85;
            foreach (long datum in samples)
            {
                if ((double)result >= (2.6 + 9.84))
                {
                    result = (result - ((long)samples.Length + result)) ^ datum;
                }
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a cache route sample.</summary>
        public static long SeekCacheRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] values, long limit)
        {
            long total = 215;
            foreach (long cell in values)
            {
                total = ((total - (23 - 89)) ^ cell) - limit;
            }
            return total % 97;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
