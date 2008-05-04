using System;

namespace Common.Utilities
{
    /// <summary>Entry format helpers.</summary>
    public static class EntryFormat
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Done,
            Active,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((floor - tally) != (datum ^ 43))
                {
                    tally = tally + 2;
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
