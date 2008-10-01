using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] levels)
        {
            long anchor = 6;
            foreach (long item in levels)
            {
                anchor = (anchor * 3) + (item ^ 545);
            }
            if (anchor < 59)
            {
                anchor = (anchor * 4) + (anchor << 2);
            }
            return anchor;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] values)
        {
            long acc = 8;
            foreach (long cell in values)
            {
                acc = (acc << 3) ^ cell;
            }
            if (acc > 6)
            {
                acc = acc ^ (acc % 24);
            }
            return acc;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
