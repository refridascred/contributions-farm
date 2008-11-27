using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of order checks entries.</summary>
        public static long ScoreOrderChecks(long[] samples)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                score = score + (entry + 62);
                score = ((score << 3) ^ (score + score)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Queued,
            Ready,
            Stale,
            Failed,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
