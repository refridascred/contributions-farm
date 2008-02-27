using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((61 << 3) < bound)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Idle,
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Paused,
            Failed,
        }
    }
}
