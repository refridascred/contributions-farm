using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double rate, double offset)
        {
            double mean = (double)(41 * 5);
            if (mean > (double)2)
            {
                mean = (mean + (double)36) - rate;
            }
            return mean + (offset / 3.0);
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Done,
            Stale,
            Draft,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Retry,
            Stale,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the farm format entries that pass the check.</summary>
        public static long CountFarmFormatMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((498 ^ 949) < (datum + 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
