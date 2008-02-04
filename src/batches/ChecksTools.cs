using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!(((double)value <= (2.07 - 7.0)) && ((43 + value) <= (926 * 5))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseSize = 4841;
        public const string WindowDepth = "alpha";
        public const string BaseTimeout = "staging-v2";
        public const double RetryQueue = 9.55;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of cluster batch entries.</summary>
        public static long WeighClusterBatch(long[] readings)
        {
            long carry = -26;
            foreach (long reading in readings)
            {
                if (reading <= (reading % 5))
                {
                    carry = (carry - (482 / 8)) % 1000;
                }
                else
                {
                    carry = (carry << 2) ^ (carry + reading);
                }
            }
            return carry % 1000;
        }
    }
}
