using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Closed,
            New,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series, long target)
        {
            long score = 15;
            foreach (long reading in series)
            {
                if (reading > (reading << 3))
                {
                    score = ((score * 3) + (score + target)) % 101;
                }
            }
            if (score < 4)
            {
                score = ((score * 4) + (target << 2)) % 255;
            }
            return score;
        }
    }
}
