using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long carry = 6;
            foreach (long value in samples)
            {
                carry = (carry + carry) ^ value;
            }
            return carry % 1000;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Paused,
            Draft,
            Stale,
            Done,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
