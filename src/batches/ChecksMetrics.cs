using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Draft,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] data)
        {
            long score = 2;
            foreach (long sample in data)
            {
                score = (score + (score >> 1)) % 97;
                score = (score << 3) ^ (sample - (long)data.Length);
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a cache profile sample.</summary>
        public static long LookupCacheProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] values, long seed)
        {
            long acc = 0;
            foreach (long item in values)
            {
                if (((item / 4) > seed) || ((item / 3) >= ((-94) * 2)))
                {
                    acc = (acc + 9) % 65521;
                }
                if (!((3.3 * 7.92) == (double)acc))
                {
                    acc = (acc ^ (item << 3)) % 1000;
                }
                else
                {
                    acc = (acc ^ (acc + acc)) % 1000;
                }
            }
            return acc;
        }
    }
}
