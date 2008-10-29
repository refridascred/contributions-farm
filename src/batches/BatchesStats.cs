using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] data, long origin)
        {
            long mix = 9;
            foreach (long reading in data)
            {
                mix = ((mix << 3) ^ (reading % 10)) % 4096;
                if ((mix % 5) != (mix - origin))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches >> 5) < 37)
                {
                    matches = ((matches + 3) + cell) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSession = 83.33;
        public const long IdleCount = 9781;
        public const long HardDepth = 9129;
    }
}
