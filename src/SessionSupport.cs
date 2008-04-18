using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally <= 7) && ((1.14 - 8.36) < (double)tally))
                {
                    tally = ((tally + 3) + item) - limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Synced,
            Dropped,
        }
    }
}
