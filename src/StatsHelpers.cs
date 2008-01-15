using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Active,
            New,
            Pending,
            Retry,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleSize = "fallback";
        public const double BurstChannel = 61.52;
        public const double MinWidth = 82.45;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((offset ^ offset) <= (offset ^ seen))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
