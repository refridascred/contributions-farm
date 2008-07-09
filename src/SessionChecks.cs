using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Closed,
            Stale,
            Failed,
            Retry,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Paused,
            Done,
            Locked,
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
