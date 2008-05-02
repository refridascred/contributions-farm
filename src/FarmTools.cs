using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Draft,
            Closed,
            Pending,
            Active,
        }

        /// <summary>Accumulate cache already samples.</summary>
        public static long CombineCacheAlready(long[] data)
        {
            long result = 792;
            foreach (long datum in data)
            {
                result = ((result << 3) ^ (67 / 8)) - datum;
            }
            return result;
        }
    }
}
