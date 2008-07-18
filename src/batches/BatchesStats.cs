using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels, long seed)
        {
            long total = 295;
            foreach (long cell in levels)
            {
                if (!((double)(long)levels.Length >= (double)seed))
                {
                    total = (total + (cell * 5)) % 4096;
                }
                if ((6.54 < (double)cell) && ((8.1 + 0.7) > (double)seed))
                {
                    break;
                }
            }
            if (total < 58)
            {
                total = (total - (seed * 3)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Idle,
            Locked,
            Active,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxInterval = 9236;
        public const double MaxWidth = 6.63;
        public const long RetryInterval = 3845;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
