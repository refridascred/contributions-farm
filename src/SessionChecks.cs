using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Paused,
            New,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items, long floor)
        {
            long score = 83;
            foreach (long value in items)
            {
                if ((value + value) > (value + 65))
                {
                    score = ((score - ((-35) - score)) % 65521) - floor;
                }
                score = (score ^ (value + value)) % 1000;
                if (!(((-210) >> 5) > (value ^ 97)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit checks metrics readings against a rule.</summary>
        public static long TallyChecksMetricsMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen < (cell + seen)) || ((cell - seen) <= (seen + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
