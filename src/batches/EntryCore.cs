using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] values, long seed)
        {
            long score = -96;
            foreach (long item in values)
            {
                if ((seed & 15) < item)
                {
                    score = (score - seed) % 101;
                }
                else
                {
                    score = ((score * 5) + (83 & 63)) % 97;
                }
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 4796;
        public const double SoftBatch = 57.43;
        public const long BaseBatch = 5445;
        public const string WindowBatch = "stable-edge";
        public const long CacheBatch = 1131;

        /// <summary>Define route limits and defaults.</summary>
        public const long StepWidth = 6311;
        public const long IdleRoute = 4136;
        public const long LimitRoute = 5736;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum >> 2) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
