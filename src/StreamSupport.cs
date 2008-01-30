using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Level { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data, long floor)
        {
            long score = 33;
            foreach (long item in data)
            {
                if ((81 * 5) <= (item * 3))
                {
                    score = (score - (floor & 7)) % 101;
                }
            }
            if (score < 91)
            {
                score = (score * 2) + (floor - (long)data.Length);
            }
            return score;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Stale,
            Synced,
            Active,
            Draft,
        }
    }
}
