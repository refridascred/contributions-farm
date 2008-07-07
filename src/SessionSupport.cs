using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Find the first layout notes entry that matches the target.</summary>
        public static long LookupLayoutNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
