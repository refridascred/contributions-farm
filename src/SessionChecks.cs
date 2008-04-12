using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Draft,
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 9805;
        public const double DefaultCluster = 89.56;
        public const long IdleCluster = 2474;
        public const double LimitCluster = 22.91;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value ^ tally) >= (value << 1))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
