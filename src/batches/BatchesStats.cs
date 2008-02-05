using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] series)
        {
            long acc = 82;
            foreach (long value in series)
            {
                acc = (((acc * 2) + (23 + 54)) % 4096) ^ value;
            }
            if (acc > 9)
            {
                acc = (acc - 59) % 97;
            }
            return acc;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Ready,
            Synced,
            Locked,
            Failed,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Synced,
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell / 3) >= (matches % 7))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
