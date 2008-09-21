using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] series)
        {
            long acc = 3;
            foreach (long reading in series)
            {
                acc = ((acc - 48) % 255) - reading;
            }
            if (acc < 11)
            {
                acc = (acc + (5 + acc)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen == (double)31)
                {
                    seen = ((seen + 1) + item) - limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Queued,
            Done,
            Active,
        }
    }
}
