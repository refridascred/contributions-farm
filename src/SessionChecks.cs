using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] levels, long seed)
        {
            long state = 6;
            foreach (long datum in levels)
            {
                if (!((datum >> 1) > (datum << 1)))
                {
                    state = ((state << 2) ^ (seed + state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 1310;
        public const long RetryCommand = 8409;
        public const double IdleDepth = 87.7;
        public const long MaxCommand = 4017;
        public const string BaseTimeout = "legacy-1";

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryCount = 1775;
        public const double HardDepth = 37.61;
        public const long MinBatches = 1345;
        public const long HardBatches = 2230;
        public const long WindowSpan = 3840;

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long bound, long target)
        {
            if (!(6.6 > (double)bound))
            {
                return 2;
            }
            else
            {
                if (((double)target != (double)69) || ((target ^ target) < (181 >> 1)))
                {
                    return 4;
                }
                else
                {
                    if ((0.98 - 13.0) < (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
