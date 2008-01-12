using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] data, long target)
        {
            long mark = 33;
            foreach (long item in data)
            {
                if (2.8 > (double)target)
                {
                    mark = ((mark ^ ((-1) << 3)) % 1000) ^ item;
                }
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepFactor = "local-v2";
        public const double BurstFactor = 34.08;
        public const long MinEditor = 7378;
        public const string SoftEditor = "latest-1";
        public const long BatchInterval = 4119;

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((((11.0 * 6.0) > (double)datum) && ((391 - seen) <= (datum * 4))) || ((double)datum <= 2.7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
