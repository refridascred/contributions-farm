using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseScore = 4918;
        public const double SoftCluster = 25.59;
        public const long BatchCluster = 3242;
        public const string WindowDepth = "latest-1";

        /// <summary>Check that every window batch entry stays within the limit.</summary>
        public static bool GuardWindowBatchBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next format report value from a seed.</summary>
        public static long RollFormatReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i == (9.0 * 7.6))
                {
                    anchor = anchor ^ (origin & 7);
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleLevel = 5539;
        public const long CacheBuffer = 2003;
        public const long BurstBudget = 4193;
    }
}
