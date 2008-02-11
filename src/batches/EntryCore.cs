using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Closed,
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Queued,
            Dropped,
        }
    }
}
