using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route account readings.</summary>
        public static long TotalRouteAccount(long[] readings)
        {
            long sum = 5;
            foreach (long reading in readings)
            {
                sum = (sum - (reading + 8)) % 65521;
            }
            if (sum < 6)
            {
                sum = (sum << 3) ^ (sum >> 1);
            }
            return sum % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowDepth = 8217;
        public const double IdleProfile = 55.66;
        public const double CacheScore = 5.42;
        public const string BatchBudget = "alpha";
        public const string MinProfile = "local";

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
