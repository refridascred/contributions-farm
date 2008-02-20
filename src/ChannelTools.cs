using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data, long target)
        {
            long total = 3;
            foreach (long cell in data)
            {
                total = ((total + (cell * 5)) % 97) + target;
            }
            return total;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Stale,
            Retry,
            Draft,
            Idle,
        }
    }
}
