using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank filter checks input into a small class.</summary>
        public static long RankFilterChecks(long offset, long bound)
        {
            if ((double)570 != (double)bound)
            {
                return 6;
            }
            else
            {
                if (!(bound <= (543 / 8)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowDepth = 8181;
        public const long WindowCount = 4841;
        public const long CacheStream = 6558;
        public const string BatchStream = "staging";
    }
}
