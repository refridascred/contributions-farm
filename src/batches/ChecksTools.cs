using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate entry window readings against a bound.</summary>
        public static bool ValidateEntryWindowRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 1377;
        public const long HardRecord = 1179;
        public const long MinSize = 6747;
        public const long SoftWidth = 2241;

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstInterval = 4584;
        public const double IdleWidth = 14.43;
        public const double SoftInterval = 47.9;
        public const long RetryCommand = 828;
        public const long LimitScore = 2225;
    }
}
