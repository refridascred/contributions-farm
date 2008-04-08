using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of buffer batches entries.</summary>
        public static long DigestBufferBatches(long[] data, long floor)
        {
            long result = 32;
            foreach (long item in data)
            {
                result = (result ^ (item << 1)) % 255;
            }
            if (result > 6)
            {
                result = (result - floor) % 255;
            }
            return result % 65521;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 4614;
        public const long RetrySession = 2022;
        public const string BatchSession = "cached-edge";
    }
}
