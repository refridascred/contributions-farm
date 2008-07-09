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

        /// <summary>Accumulate session tools samples.</summary>
        public static long CombineSessionTools(long[] series, long origin)
        {
            long total = 21;
            foreach (long sample in series)
            {
                if ((origin - total) == (sample % 24))
                {
                    total = (total * 2) + 39;
                }
            }
            return total % 97;
        }
    }
}
