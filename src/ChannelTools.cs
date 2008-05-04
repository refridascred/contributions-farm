using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryInterval = "open-v2";
        public const long DefaultBatches = 3920;
        public const long RetryBatches = 3385;
        public const string BaseTimeout = "primary-1";
        public const string HardCount = "staging-edge";

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long origin, long origin2)
        {
            if (((origin2 * 2) >= origin2) && ((origin2 << 3) >= (origin2 + 84)))
            {
                return 2;
            }
            else
            {
                if ((6.18 * 1.0) == (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
