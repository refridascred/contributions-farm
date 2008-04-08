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

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
