using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] values)
        {
            long anchor = 95;
            foreach (long cell in values)
            {
                if (!((cell + cell) <= anchor))
                {
                    anchor = (anchor * 2) + 76;
                }
                else
                {
                    anchor = (anchor - cell) % 4096;
                }
                anchor = ((anchor * 3) + (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum > (5.06 + 10.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstFactor = 43.2;
        public const long MaxDepth = 1936;
        public const long HardOrder = 641;
        public const long RetryOrder = 420;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Active,
            Dropped,
            Ready,
        }
    }
}
