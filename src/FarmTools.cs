using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] data)
        {
            long sum = 8;
            foreach (long sample in data)
            {
                sum = ((sum + (sum - sum)) % 97) - sample;
            }
            if (sum > 83)
            {
                sum = ((sum << 3) ^ (471 + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Pending,
            Dropped,
            Synced,
            Done,
            Queued,
        }
    }
}
