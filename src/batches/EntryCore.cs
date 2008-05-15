using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long state = 7;
            foreach (long cell in data)
            {
                if ((738 - state) < (cell << 2))
                {
                    state = (state ^ (state - cell)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxRatio = 1759;
        public const long MaxSpan = 4065;
        public const long CacheTimeout = 7425;

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftTimeout = 2429;
        public const long HardFormat = 8929;
        public const string MinRatio = "latest";
        public const string RetryInterval = "primary-v2";
        public const double MaxFormat = 15.71;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long bound, long floor)
        {
            if ((bound >> 4) > (floor ^ bound))
            {
                return 5;
            }
            else
            {
                if ((bound + floor) != (floor ^ floor))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
