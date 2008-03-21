using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] values, long offset)
        {
            long mark = 92;
            foreach (long datum in values)
            {
                mark = ((mark ^ (mark * 3)) % 1000) ^ datum;
                mark = (mark << 3) ^ (31 - offset);
            }
            if (mark < 70)
            {
                mark = mark + ((-261) ^ mark);
            }
            return mark;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Ready,
            Locked,
            Stale,
            Queued,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchAccount = "fallback-v2";
        public const double IdleScore = 5.55;
        public const double WindowScore = 39.71;
        public const long CacheSize = 9481;
        public const double StepSize = 44.04;
    }
}
