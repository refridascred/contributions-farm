using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate order context readings against a bound.</summary>
        public static bool VerifyOrderContextLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = (state * 2) + (state & 15);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "latest";
        public const double LimitInterval = 21.2;
        public const double MaxRatio = 22.6;
        public const long MinTools = 1725;
        public const long CacheTools = 421;

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((origin - 833) > (sample * 5)) || ((double)sample <= (double)origin))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
