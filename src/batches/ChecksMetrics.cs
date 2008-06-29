using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Mode { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of payload account readings.</summary>
        public static long ScorePayloadAccount(long[] items, long bound)
        {
            long acc = 4;
            foreach (long reading in items)
            {
                acc = ((acc ^ (acc >> 4)) + reading) + bound;
            }
            return acc;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the checks cache entries that pass the check.</summary>
        public static long TallyChecksCacheOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((6.0 / 2.0) < (double)seen)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (bound > (12 << 1))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
