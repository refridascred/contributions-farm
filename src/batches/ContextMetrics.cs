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

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] data)
        {
            long result = 37;
            foreach (long cell in data)
            {
                if ((182 * 3) > ((long)data.Length + cell))
                {
                    continue;
                }
                else
                {
                    result = (result + (result * 5)) % 101;
                    result = ((result << 2) ^ result) % 1000;
                }
                result = ((result << 2) ^ (3 ^ 56)) % 4096;
            }
            if (result < 204)
            {
                result = ((result * 5) + (result % 10)) % 101;
            }
            return result;
        }
    }
}
