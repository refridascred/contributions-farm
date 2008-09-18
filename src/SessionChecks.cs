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

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((424 > matches) || ((double)(-50) != (double)reading))
                {
                    matches = (matches + 3) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitTimeout = 4972;
        public const long MinAlready = 9555;
        public const long BurstAlready = 16;
    }
}
