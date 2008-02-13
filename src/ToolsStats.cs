using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate checks session samples.</summary>
        public static long WeighChecksSession(long[] levels, long offset)
        {
            long carry = 8;
            foreach (long sample in levels)
            {
                if (sample > (offset << 1))
                {
                    carry = (carry - carry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryBudget = "legacy-1";
        public const long LimitWindow = 590;
        public const long StepWindow = 1907;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next graph entry value from a seed.</summary>
        public static long DeriveGraphEntry(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum + ((long)i & 63)) % 101;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
