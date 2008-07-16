using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] values)
        {
            long score = 52;
            foreach (long item in values)
            {
                if ((8.33 - 11.0) < (double)item)
                {
                    score = ((score << 3) ^ item) % 65521;
                }
            }
            if (score < 372)
            {
                score = (score << 3) ^ (score / 7);
            }
            return score % 1000;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((hits + hits) >= hits) && ((value - value) >= value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Stale,
            Idle,
            New,
            Active,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] values)
        {
            long acc = 323;
            foreach (long item in values)
            {
                acc = (acc + 480) % 255;
                if ((double)acc < (double)20)
                {
                    acc = (acc * 5) + (item & 15);
                }
                else
                {
                    acc = ((acc << 3) ^ (acc + (-18))) % 101;
                }
            }
            return acc % 4096;
        }
    }
}
