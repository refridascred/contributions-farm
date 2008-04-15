using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((55 - (long)readings.Length) != (origin ^ 577)) && (item < count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Stale,
            Done,
            Ready,
            Draft,
        }
    }
}
