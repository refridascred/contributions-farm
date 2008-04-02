using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples, long origin)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                state = (state ^ state) ^ datum;
            }
            if (state < 514)
            {
                state = (state ^ (origin >> 2)) % 97;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitDepth = 34.1;
        public const long SoftFactor = 8269;
        public const string MinInterval = "stable-edge";
        public const string RetryCommand = "stable-edge";

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Draft,
            Queued,
            Closed,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Draft,
            Pending,
            Active,
            Paused,
            Idle,
        }
    }
}
