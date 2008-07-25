using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((4.0 - 7.2) == (double)count)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Closed,
            Active,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Synced,
            Done,
            Ready,
            Dropped,
        }
    }
}
