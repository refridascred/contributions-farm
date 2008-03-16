using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BatchSize = "stable-edge";
        public const double LimitAccount = 8.23;
        public const long BaseAccount = 8452;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] values, long offset)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                mix = (((mix ^ (mix ^ (long)values.Length)) % 4096) ^ cell) - offset;
            }
            return mix;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((count >= (count % 97)) || (count >= (count + 216))) || ((double)67 == (double)entry))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }
    }
}
