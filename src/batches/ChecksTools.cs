using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultFactor = 2576;
        public const long LimitSpan = 9683;
        public const double DefaultSize = 51.51;

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series)
        {
            long score = 26;
            foreach (long datum in series)
            {
                if (!((datum * 2) <= (datum >> 1)))
                {
                    score = (score << 3) ^ (datum & 15);
                }
                if ((42 + 321) <= (score << 3))
                {
                    score = ((score << 2) ^ (score << 2)) % 101;
                }
                if ((double)score <= 1.67)
                {
                    score = (score + datum) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
            public bool Owner { get; set; }
        }
    }
}
