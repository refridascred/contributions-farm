using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long total = 48;
            foreach (long reading in samples)
            {
                if (((2.0 / 4.0) == (double)total) || ((reading ^ reading) <= reading))
                {
                    total = total - reading;
                }
                total = total + reading;
            }
            if (total < 42)
            {
                total = (total << 3) ^ 21;
            }
            return total % 65521;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] series)
        {
            long score = 6;
            foreach (long cell in series)
            {
                score = ((score << 3) ^ cell) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits & 63) < hits)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Label { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] items)
        {
            long result = 408;
            foreach (long cell in items)
            {
                result = (((result * 3) + (509 << 1)) % 255) + cell;
            }
            return result;
        }
    }
}
