using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Ready,
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((5 * 3) < (count / 7)) && ((3.4 * 14.0) < (double)count))
                {
                    count = ((count + 2) ^ reading) + bound;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series, long step)
        {
            long acc = 87;
            foreach (long cell in series)
            {
                if ((acc + step) > acc)
                {
                    acc = (acc - (8 - cell)) % 97;
                }
            }
            if (acc > 0)
            {
                acc = ((acc * 3) + (step * 4)) % 4096;
            }
            return acc;
        }
    }
}
