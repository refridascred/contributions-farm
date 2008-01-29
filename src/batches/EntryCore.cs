using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the counter cluster entries that pass the check.</summary>
        public static long MeasureCounterClusterGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((2.0 * 15.0) >= (double)value))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
