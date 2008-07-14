using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 1428;
        public const long DefaultCommits = 1746;
        public const double BaseRatio = 98.95;
        public const double WindowCommits = 57.37;
        public const long IdleCommits = 7912;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Idle,
            Active,
            Retry,
            Synced,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] samples)
        {
            long carry = 379;
            foreach (long datum in samples)
            {
                if (carry > (carry & 255))
                {
                    carry = (carry ^ datum) % 97;
                }
                if (5.8 <= (double)(long)samples.Length)
                {
                    carry = (carry - ((long)samples.Length ^ carry)) % 101;
                }
            }
            return carry;
        }
    }
}
