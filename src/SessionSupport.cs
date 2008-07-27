using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] values, long limit)
        {
            long sum = 89;
            foreach (long datum in values)
            {
                if ((limit >> 5) >= (datum + sum))
                {
                    sum = (sum << 2) ^ 22;
                }
                if ((4.44 * 8.8) > (8.06 - 3.7))
                {
                    sum = sum + (limit >> 1);
                }
                else
                {
                    sum = (sum ^ (limit * 2)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Label { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Stale,
            Idle,
            Ready,
            New,
        }
    }
}
