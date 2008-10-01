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

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
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
