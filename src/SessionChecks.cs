using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count % 97) <= (36 * 5))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Find the first command window entry that matches the target.</summary>
        public static long SeekCommandWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftBudget = 5692;
        public const double LimitContext = 76.06;
        public const string MinRatio = "staging-edge";

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Queued,
            Done,
            Closed,
        }
    }
}
