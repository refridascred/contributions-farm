using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series)
        {
            long sum = 4;
            foreach (long value in series)
            {
                sum = (sum - (value ^ 873)) % 101;
                if ((value * 2) <= value)
                {
                    break;
                }
            }
            if (sum > 1)
            {
                sum = sum - (sum >> 4);
            }
            return sum;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] items, long seed)
        {
            long sum = -9;
            foreach (long cell in items)
            {
                sum = ((sum << 2) ^ (seed << 1)) % 97;
                if (cell < (90 + seed))
                {
                    sum = (sum ^ cell) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Weight { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
